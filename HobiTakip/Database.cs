using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;
using HobiTakip.Models;
using System.Security.Cryptography;
using System.Text;

namespace HobiTakip
{
    public class Database
    {
        private readonly string _connectionString;
        private readonly string _dbPath;

        public Database()
        {
            // Veritabanını kullanıcının AppData klasörüne yerleştir (yazma izni güvenli)
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataDir, "HobiTakip");
            
            // Klasör yoksa oluştur
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }
            
            _dbPath = Path.Combine(appFolder, "hobitakip.db");
            _connectionString = $"Data Source={_dbPath}";
            
            // Eski veritabanı dosyasını yeni konuma taşı (eğer varsa)
            MigrateOldDatabase();
            
            InitializeDatabase();
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        private void MigrateOldDatabase()
        {
            try
            {
                // Eski konumda veritabanı dosyası var mı kontrol et
                string oldAppDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ?? "";
                string oldDbPath = Path.Combine(oldAppDir, "hobitakip.db");
                
                // Eski dosya varsa ve yeni konumda yoksa taşı
                if (File.Exists(oldDbPath) && !File.Exists(_dbPath))
                {
                    File.Copy(oldDbPath, _dbPath);
                    
                    // Eski dosyayı sil (isteğe bağlı)
                    try
                    {
                        File.Delete(oldDbPath);
                    }
                    catch
                    {
                        // Silemediyse sora yok, yeni konumda çalışır
                    }
                }
            }
            catch
            {
                // Migrasyon hatası olursa da sorun yok, yeni veritabanı oluşturulacak
            }
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            // Users tablosu
            var createUsersTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE NOT NULL,
                    Password TEXT NOT NULL,
                    FullName TEXT NOT NULL,
                    Email TEXT,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
                )";

            // Hobbies tablosu
            var createHobbiesTable = @"
                CREATE TABLE IF NOT EXISTS Hobbies (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Name TEXT NOT NULL,
                    Description TEXT,
                    Category TEXT,
                    StartDate DATETIME,
                    IsActive BOOLEAN DEFAULT 1,
                    DifficultyLevel TEXT,
                    TotalTimeSpent INTEGER DEFAULT 0,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (UserId) REFERENCES Users (Id)
                )";

            // Goals tablosu
            var createGoalsTable = @"
                CREATE TABLE IF NOT EXISTS Goals (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    HobbyId INTEGER NOT NULL,
                    Title TEXT NOT NULL,
                    Description TEXT,
                    TargetDate DATETIME,
                    TargetValue INTEGER DEFAULT 0,
                    Unit TEXT,
                    CurrentValue INTEGER DEFAULT 0,
                    IsCompleted BOOLEAN DEFAULT 0,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    CompletedDate DATETIME,
                    FOREIGN KEY (HobbyId) REFERENCES Hobbies (Id)
                )";

            // Progress tablosu
            var createProgressTable = @"
                CREATE TABLE IF NOT EXISTS Progress (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    HobbyId INTEGER NOT NULL,
                    GoalId INTEGER,
                    Date DATETIME NOT NULL,
                    TimeSpent INTEGER DEFAULT 0,
                    Value INTEGER DEFAULT 0,
                    Unit TEXT,
                    Notes TEXT,
                    Rating INTEGER DEFAULT 0,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (HobbyId) REFERENCES Hobbies (Id),
                    FOREIGN KEY (GoalId) REFERENCES Goals (Id)
                )";

            // Achievements tablosu
            var createAchievementsTable = @"
                CREATE TABLE IF NOT EXISTS Achievements (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT,
                    Icon TEXT,
                    Category TEXT,
                    RequiredValue INTEGER DEFAULT 0,
                    RequirementType TEXT,
                    IsActive BOOLEAN DEFAULT 1,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
                )";

            // UserAchievements tablosu
            var createUserAchievementsTable = @"
                CREATE TABLE IF NOT EXISTS UserAchievements (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    AchievementId INTEGER NOT NULL,
                    UnlockedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    IsNew BOOLEAN DEFAULT 1,
                    FOREIGN KEY (UserId) REFERENCES Users (Id),
                    FOREIGN KEY (AchievementId) REFERENCES Achievements (Id)
                )";

            // UserSettings tablosu
            var createUserSettingsTable = @"
                CREATE TABLE IF NOT EXISTS UserSettings (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER UNIQUE NOT NULL,
                    Theme TEXT DEFAULT 'Light',
                    NotificationsEnabled BOOLEAN DEFAULT 1,
                    ReminderFrequency INTEGER DEFAULT 24,
                    PomodoroSoundEnabled BOOLEAN DEFAULT 1,
                    PomodoroWorkMinutes INTEGER DEFAULT 25,
                    PomodoroBreakMinutes INTEGER DEFAULT 5,
                    LastReminderSent DATETIME,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (UserId) REFERENCES Users (Id)
                )";

            ExecuteCommand(connection, createUsersTable);
            ExecuteCommand(connection, createHobbiesTable);
            ExecuteCommand(connection, createGoalsTable);
            ExecuteCommand(connection, createProgressTable);
            ExecuteCommand(connection, createAchievementsTable);
            ExecuteCommand(connection, createUserAchievementsTable);
            ExecuteCommand(connection, createUserSettingsTable);
            
            // Başlangıç rozetlerini ekle
            InitializeAchievements(connection);
        }

        private void ExecuteCommand(SqliteConnection connection, string sql)
        {
            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        private void InitializeAchievements(SqliteConnection connection)
        {
            // Rozet var mı kontrol et
            var checkSql = "SELECT COUNT(*) FROM Achievements";
            using var checkCommand = new SqliteCommand(checkSql, connection);
            var count = Convert.ToInt32(checkCommand.ExecuteScalar());
            
            if (count == 0)
            {
                var achievements = new[]
                {
                    ("İlk Adım", "İlk hobinizi eklediğiniz için tebrikler!", "🎯", "Başlangıç", 1, "FirstHobby"),
                    ("İlerleme Kayıtçısı", "İlk ilerlemenizi kaydettiniz!", "📝", "Başlangıç", 1, "FirstProgress"),
                    ("Hedefli Yaklaşım", "İlk hedefinizi belirlediniz!", "🎯", "Başlangıç", 1, "FirstGoal"),
                    ("Saat Tamamlayıcı", "Toplam 10 saat hobi yaptınız!", "⏰", "Zaman", 600, "TotalMinutes"),
                    ("Zaman Ustası", "Toplam 50 saat hobi yaptınız!", "⏱️", "Zaman", 3000, "TotalMinutes"),
                    ("Hobi Koleksiyoncusu", "5 farklı hobi eklediğiniz için tebrikler!", "🎨", "Çeşitlilik", 5, "HobbyCount"),
                    ("Hedef Avcısı", "İlk hedefinizi tamamladınız!", "🏆", "Başarı", 1, "CompletedGoals"),
                    ("Süreklilik Kralı", "7 gün üst üste ilerleme kaydettiniz!", "🔥", "Süreklilik", 7, "Streak"),
                    ("Mükemmeliyetçi", "10 kez 5 yıldız değerlendirme verdiniz!", "⭐", "Kalite", 10, "FiveStarRatings"),
                    ("Çok Üretken", "Bir ayda 20 saat hobi yaptınız!", "💪", "Verimlilik", 1200, "MonthlyMinutes")
                };

                foreach (var (name, desc, icon, category, reqValue, reqType) in achievements)
                {
                    var sql = @"INSERT INTO Achievements (Name, Description, Icon, Category, RequiredValue, RequirementType) 
                               VALUES (@name, @desc, @icon, @category, @reqValue, @reqType)";
                    using var command = new SqliteCommand(sql, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.Parameters.AddWithValue("@icon", icon);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@reqValue", reqValue);
                    command.Parameters.AddWithValue("@reqType", reqType);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Şifre hash'leme
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "hobitakip_salt"));
            return Convert.ToBase64String(bytes);
        }

        // User işlemleri
        public bool RegisterUser(string username, string password, string fullName, string email)
        {
            try
            {
                using var connection = new SqliteConnection(_connectionString);
                connection.Open();
                
                var sql = "INSERT INTO Users (Username, Password, FullName, Email) VALUES (@username, @password, @fullname, @email)";
                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", HashPassword(password));
                command.Parameters.AddWithValue("@fullname", fullName);
                command.Parameters.AddWithValue("@email", email ?? "");
                
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public User? LoginUser(string username, string password)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", HashPassword(password));
            
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32("Id"),
                    Username = reader.GetString("Username"),
                    FullName = reader.GetString("FullName"),
                    Email = reader.GetString("Email"),
                    CreatedDate = DateTime.Parse(reader.GetString("CreatedDate"))
                };
            }
            return null;
        }

        // Hobby işlemleri
        public void AddHobby(Hobby hobby)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"INSERT INTO Hobbies (UserId, Name, Description, Category, StartDate, DifficultyLevel) 
                       VALUES (@userId, @name, @description, @category, @startDate, @difficulty)";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", hobby.UserId);
            command.Parameters.AddWithValue("@name", hobby.Name);
            command.Parameters.AddWithValue("@description", hobby.Description);
            command.Parameters.AddWithValue("@category", hobby.Category);
            command.Parameters.AddWithValue("@startDate", hobby.StartDate.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@difficulty", hobby.DifficultyLevel);
            
            command.ExecuteNonQuery();
        }

        public List<Hobby> GetUserHobbies(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM Hobbies WHERE UserId = @userId ORDER BY CreatedDate DESC";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            var hobbies = new List<Hobby>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                hobbies.Add(new Hobby
                {
                    Id = reader.GetInt32("Id"),
                    UserId = reader.GetInt32("UserId"),
                    Name = reader.GetString("Name"),
                    Description = reader.GetString("Description") ?? "",
                    Category = reader.GetString("Category") ?? "",
                    StartDate = DateTime.Parse(reader.GetString("StartDate")),
                    IsActive = reader.GetBoolean("IsActive"),
                    DifficultyLevel = reader.GetString("DifficultyLevel") ?? "",
                    TotalTimeSpent = reader.GetInt32("TotalTimeSpent"),
                    CreatedDate = DateTime.Parse(reader.GetString("CreatedDate"))
                });
            }
            return hobbies;
        }

        // Goal işlemleri
        public void AddGoal(Goal goal)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"INSERT INTO Goals (HobbyId, Title, Description, TargetDate, TargetValue, Unit) 
                       VALUES (@hobbyId, @title, @description, @targetDate, @targetValue, @unit)";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@hobbyId", goal.HobbyId);
            command.Parameters.AddWithValue("@title", goal.Title);
            command.Parameters.AddWithValue("@description", goal.Description);
            command.Parameters.AddWithValue("@targetDate", goal.TargetDate.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@targetValue", goal.TargetValue);
            command.Parameters.AddWithValue("@unit", goal.Unit);
            
            command.ExecuteNonQuery();
        }

        public List<Goal> GetHobbyGoals(int hobbyId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM Goals WHERE HobbyId = @hobbyId ORDER BY TargetDate";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@hobbyId", hobbyId);
            
            var goals = new List<Goal>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                goals.Add(new Goal
                {
                    Id = reader.GetInt32("Id"),
                    HobbyId = reader.GetInt32("HobbyId"),
                    Title = reader.GetString("Title"),
                    Description = reader.GetString("Description") ?? "",
                    TargetDate = DateTime.Parse(reader.GetString("TargetDate")),
                    TargetValue = reader.GetInt32("TargetValue"),
                    Unit = reader.GetString("Unit") ?? "",
                    CurrentValue = reader.GetInt32("CurrentValue"),
                    IsCompleted = reader.GetBoolean("IsCompleted"),
                    CreatedDate = DateTime.Parse(reader.GetString("CreatedDate")),
                    CompletedDate = reader.IsDBNull("CompletedDate") ? null : DateTime.Parse(reader.GetString("CompletedDate"))
                });
            }
            return goals;
        }

        // Progress işlemleri
        public void AddProgress(Progress progress)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"INSERT INTO Progress (HobbyId, GoalId, Date, TimeSpent, Value, Unit, Notes, Rating) 
                       VALUES (@hobbyId, @goalId, @date, @timeSpent, @value, @unit, @notes, @rating)";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@hobbyId", progress.HobbyId);
            command.Parameters.AddWithValue("@goalId", progress.GoalId);
            command.Parameters.AddWithValue("@date", progress.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@timeSpent", progress.TimeSpent);
            command.Parameters.AddWithValue("@value", progress.Value);
            command.Parameters.AddWithValue("@unit", progress.Unit);
            command.Parameters.AddWithValue("@notes", progress.Notes);
            command.Parameters.AddWithValue("@rating", progress.Rating);
            
            command.ExecuteNonQuery();
            
            // Hobi toplam süresini güncelle
            UpdateHobbyTotalTime(progress.HobbyId, progress.TimeSpent);
            
            // Eğer hedefle ilgiliyse, hedef ilerlemesini güncelle
            if (progress.GoalId.HasValue)
            {
                UpdateGoalProgress(progress.GoalId.Value, progress.Value);
            }
        }

        private void UpdateHobbyTotalTime(int hobbyId, int additionalTime)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "UPDATE Hobbies SET TotalTimeSpent = TotalTimeSpent + @time WHERE Id = @id";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@time", additionalTime);
            command.Parameters.AddWithValue("@id", hobbyId);
            
            command.ExecuteNonQuery();
        }

        private void UpdateGoalProgress(int goalId, int additionalValue)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"UPDATE Goals SET CurrentValue = CurrentValue + @value,
                       IsCompleted = CASE WHEN (CurrentValue + @value) >= TargetValue THEN 1 ELSE 0 END,
                       CompletedDate = CASE WHEN (CurrentValue + @value) >= TargetValue THEN CURRENT_TIMESTAMP ELSE CompletedDate END
                       WHERE Id = @id";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@value", additionalValue);
            command.Parameters.AddWithValue("@id", goalId);
            
            command.ExecuteNonQuery();
        }

        public List<Progress> GetHobbyProgress(int hobbyId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM Progress WHERE HobbyId = @hobbyId ORDER BY Date DESC";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@hobbyId", hobbyId);
            
            var progressList = new List<Progress>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                progressList.Add(new Progress
                {
                    Id = reader.GetInt32("Id"),
                    HobbyId = reader.GetInt32("HobbyId"),
                    GoalId = reader.IsDBNull("GoalId") ? null : reader.GetInt32("GoalId"),
                    Date = DateTime.Parse(reader.GetString("Date")),
                    TimeSpent = reader.GetInt32("TimeSpent"),
                    Value = reader.GetInt32("Value"),
                    Unit = reader.GetString("Unit") ?? "",
                    Notes = reader.GetString("Notes") ?? "",
                    Rating = reader.GetInt32("Rating"),
                    CreatedDate = DateTime.Parse(reader.GetString("CreatedDate"))
                });
            }
            return progressList;
        }
        
        // Achievement işlemleri
        public List<Achievement> GetAllAchievements()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM Achievements WHERE IsActive = 1 ORDER BY Category, RequiredValue";
            using var command = new SqliteCommand(sql, connection);
            
            var achievements = new List<Achievement>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                achievements.Add(new Achievement
                {
                    Id = reader.GetInt32("Id"),
                    Name = reader.GetString("Name"),
                    Description = reader.GetString("Description") ?? "",
                    Icon = reader.GetString("Icon") ?? "",
                    Category = reader.GetString("Category") ?? "",
                    RequiredValue = reader.GetInt32("RequiredValue"),
                    RequirementType = reader.GetString("RequirementType") ?? "",
                    IsActive = reader.GetBoolean("IsActive"),
                    CreatedDate = DateTime.Parse(reader.GetString("CreatedDate"))
                });
            }
            return achievements;
        }
        
        public List<UserAchievement> GetUserAchievements(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM UserAchievements WHERE UserId = @userId ORDER BY UnlockedDate DESC";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            var userAchievements = new List<UserAchievement>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                userAchievements.Add(new UserAchievement
                {
                    Id = reader.GetInt32("Id"),
                    UserId = reader.GetInt32("UserId"),
                    AchievementId = reader.GetInt32("AchievementId"),
                    UnlockedDate = DateTime.Parse(reader.GetString("UnlockedDate")),
                    IsNew = reader.GetBoolean("IsNew")
                });
            }
            return userAchievements;
        }
        
        public void UnlockAchievement(int userId, int achievementId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            // Zaten var mı kontrol et
            var checkSql = "SELECT COUNT(*) FROM UserAchievements WHERE UserId = @userId AND AchievementId = @achievementId";
            using var checkCommand = new SqliteCommand(checkSql, connection);
            checkCommand.Parameters.AddWithValue("@userId", userId);
            checkCommand.Parameters.AddWithValue("@achievementId", achievementId);
            
            var exists = Convert.ToInt32(checkCommand.ExecuteScalar()) > 0;
            if (!exists)
            {
                var sql = "INSERT INTO UserAchievements (UserId, AchievementId) VALUES (@userId, @achievementId)";
                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@achievementId", achievementId);
                command.ExecuteNonQuery();
            }
        }
        
        public void CheckAndUnlockAchievements(int userId)
        {
            var achievements = GetAllAchievements();
            var userAchievements = GetUserAchievements(userId);
            var unlockedIds = userAchievements.Select(ua => ua.AchievementId).ToHashSet();
            
            foreach (var achievement in achievements)
            {
                if (unlockedIds.Contains(achievement.Id)) continue;
                
                bool shouldUnlock = achievement.RequirementType switch
                {
                    "FirstHobby" => GetUserHobbies(userId).Count >= achievement.RequiredValue,
                    "FirstProgress" => GetAllUserProgress(userId).Count >= achievement.RequiredValue,
                    "FirstGoal" => GetAllUserGoals(userId).Count >= achievement.RequiredValue,
                    "TotalMinutes" => GetTotalUserMinutes(userId) >= achievement.RequiredValue,
                    "HobbyCount" => GetUserHobbies(userId).Count >= achievement.RequiredValue,
                    "CompletedGoals" => GetCompletedGoalsCount(userId) >= achievement.RequiredValue,
                    "FiveStarRatings" => GetFiveStarRatingsCount(userId) >= achievement.RequiredValue,
                    _ => false
                };
                
                if (shouldUnlock)
                {
                    UnlockAchievement(userId, achievement.Id);
                }
            }
        }
        
        // Settings işlemleri
        public UserSettings GetUserSettings(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = "SELECT * FROM UserSettings WHERE UserId = @userId";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new UserSettings
                {
                    Id = reader.GetInt32("Id"),
                    UserId = reader.GetInt32("UserId"),
                    Theme = reader.GetString("Theme"),
                    NotificationsEnabled = reader.GetBoolean("NotificationsEnabled"),
                    ReminderFrequency = reader.GetInt32("ReminderFrequency"),
                    PomodoroSoundEnabled = reader.GetBoolean("PomodoroSoundEnabled"),
                    PomodoroWorkMinutes = reader.GetInt32("PomodoroWorkMinutes"),
                    PomodoroBreakMinutes = reader.GetInt32("PomodoroBreakMinutes"),
                    LastReminderSent = reader.IsDBNull("LastReminderSent") ? DateTime.MinValue : DateTime.Parse(reader.GetString("LastReminderSent")),
                    CreatedDate = DateTime.Parse(reader.GetString("CreatedDate")),
                    UpdatedDate = DateTime.Parse(reader.GetString("UpdatedDate"))
                };
            }
            
            // Yoksa varsayılan ayarlar oluştur
            return CreateDefaultSettings(userId);
        }
        
        public UserSettings CreateDefaultSettings(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"INSERT INTO UserSettings (UserId) VALUES (@userId)";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.ExecuteNonQuery();
            
            return GetUserSettings(userId);
        }
        
        public void UpdateUserSettings(UserSettings settings)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"UPDATE UserSettings SET 
                       Theme = @theme, 
                       NotificationsEnabled = @notifications,
                       ReminderFrequency = @reminderFreq,
                       PomodoroSoundEnabled = @pomodoroSound,
                       PomodoroWorkMinutes = @workMinutes,
                       PomodoroBreakMinutes = @breakMinutes,
                       UpdatedDate = CURRENT_TIMESTAMP
                       WHERE UserId = @userId";
            
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@theme", settings.Theme);
            command.Parameters.AddWithValue("@notifications", settings.NotificationsEnabled);
            command.Parameters.AddWithValue("@reminderFreq", settings.ReminderFrequency);
            command.Parameters.AddWithValue("@pomodoroSound", settings.PomodoroSoundEnabled);
            command.Parameters.AddWithValue("@workMinutes", settings.PomodoroWorkMinutes);
            command.Parameters.AddWithValue("@breakMinutes", settings.PomodoroBreakMinutes);
            command.Parameters.AddWithValue("@userId", settings.UserId);
            
            command.ExecuteNonQuery();
        }
        
        // Yardımcı metodlar
        private List<Progress> GetAllUserProgress(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"SELECT p.* FROM Progress p 
                       INNER JOIN Hobbies h ON p.HobbyId = h.Id 
                       WHERE h.UserId = @userId";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            var progressList = new List<Progress>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                progressList.Add(new Progress
                {
                    Id = reader.GetInt32("Id"),
                    HobbyId = reader.GetInt32("HobbyId"),
                    Date = DateTime.Parse(reader.GetString("Date")),
                    TimeSpent = reader.GetInt32("TimeSpent"),
                    Rating = reader.GetInt32("Rating")
                });
            }
            return progressList;
        }
        
        private List<Goal> GetAllUserGoals(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"SELECT g.* FROM Goals g 
                       INNER JOIN Hobbies h ON g.HobbyId = h.Id 
                       WHERE h.UserId = @userId";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            var goals = new List<Goal>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                goals.Add(new Goal { Id = reader.GetInt32("Id") });
            }
            return goals;
        }
        
        private int GetTotalUserMinutes(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"SELECT COALESCE(SUM(h.TotalTimeSpent), 0) FROM Hobbies h WHERE h.UserId = @userId";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            return Convert.ToInt32(command.ExecuteScalar());
        }
        
        private int GetCompletedGoalsCount(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"SELECT COUNT(*) FROM Goals g 
                       INNER JOIN Hobbies h ON g.HobbyId = h.Id 
                       WHERE h.UserId = @userId AND g.IsCompleted = 1";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            return Convert.ToInt32(command.ExecuteScalar());
        }
        
        private int GetFiveStarRatingsCount(int userId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var sql = @"SELECT COUNT(*) FROM Progress p 
                       INNER JOIN Hobbies h ON p.HobbyId = h.Id 
                       WHERE h.UserId = @userId AND p.Rating = 5";
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@userId", userId);
            
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
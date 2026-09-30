using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using HobiTakip.Models;

namespace HobiTakip
{
    public static class DataExporter
    {
        public static void ExportUserData(int userId, Database database, string filePath)
        {
            try
            {
                var exportData = new UserDataExport
                {
                    ExportDate = DateTime.Now,
                    UserId = userId,
                    Hobbies = database.GetUserHobbies(userId),
                    Achievements = GetUserAchievementsWithDetails(userId, database),
                    Settings = database.GetUserSettings(userId)
                };

                // Tüm hobi verilerini topla
                foreach (var hobby in exportData.Hobbies)
                {
                    var hobbyData = new HobbyDataExport
                    {
                        Hobby = hobby,
                        Goals = database.GetHobbyGoals(hobby.Id),
                        Progress = database.GetHobbyProgress(hobby.Id)
                    };
                    exportData.HobbyData.Add(hobbyData);
                }

                // JSON formatında kaydet
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                var jsonString = JsonSerializer.Serialize(exportData, options);
                File.WriteAllText(filePath, jsonString, System.Text.Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri dışa aktarımında hata oluştu: {ex.Message}");
            }
        }

        private static List<AchievementDataExport> GetUserAchievementsWithDetails(int userId, Database database)
        {
            var userAchievements = database.GetUserAchievements(userId);
            var allAchievements = database.GetAllAchievements();
            var achievementExports = new List<AchievementDataExport>();

            foreach (var userAchievement in userAchievements)
            {
                var achievement = allAchievements.FirstOrDefault(a => a.Id == userAchievement.AchievementId);
                if (achievement != null)
                {
                    achievementExports.Add(new AchievementDataExport
                    {
                        Achievement = achievement,
                        UnlockedDate = userAchievement.UnlockedDate
                    });
                }
            }

            return achievementExports;
        }

        public static void ExportToCSV(int userId, Database database, string filePath)
        {
            try
            {
                var csvContent = new System.Text.StringBuilder();
                
                // Başlık satırı
                csvContent.AppendLine("Tarih,Hobi,Süre(dk),Yapılan İş,Birim,Değerlendirme,Notlar");

                // Tüm hobi verilerini topla
                var hobbies = database.GetUserHobbies(userId);
                foreach (var hobby in hobbies)
                {
                    var progressList = database.GetHobbyProgress(hobby.Id);
                    foreach (var progress in progressList)
                    {
                        var line = $"{progress.Date:yyyy-MM-dd},{hobby.Name},{progress.TimeSpent}," +
                                  $"{progress.Value},{progress.Unit},{progress.Rating},\"{progress.Notes}\"";
                        csvContent.AppendLine(line);
                    }
                }

                File.WriteAllText(filePath, csvContent.ToString(), System.Text.Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"CSV dışa aktarımında hata oluştu: {ex.Message}");
            }
        }
    }

    // Export model sınıfları
    public class UserDataExport
    {
        public DateTime ExportDate { get; set; }
        public int UserId { get; set; }
        public List<Hobby> Hobbies { get; set; } = new();
        public List<HobbyDataExport> HobbyData { get; set; } = new();
        public List<AchievementDataExport> Achievements { get; set; } = new();
        public UserSettings Settings { get; set; } = new();
    }

    public class HobbyDataExport
    {
        public Hobby Hobby { get; set; } = new();
        public List<Goal> Goals { get; set; } = new();
        public List<Progress> Progress { get; set; } = new();
    }

    public class AchievementDataExport
    {
        public Achievement Achievement { get; set; } = new();
        public DateTime UnlockedDate { get; set; }
    }
}
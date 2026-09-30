using System;

namespace HobiTakip.Models
{
    public class UserSettings
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Theme { get; set; } = "Light"; // Light, Dark, System
        public bool NotificationsEnabled { get; set; } = true;
        public int ReminderFrequency { get; set; } = 24; // Saat cinsinden
        public bool PomodoroSoundEnabled { get; set; } = true;
        public int PomodoroWorkMinutes { get; set; } = 25;
        public int PomodoroBreakMinutes { get; set; } = 5;
        public DateTime LastReminderSent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
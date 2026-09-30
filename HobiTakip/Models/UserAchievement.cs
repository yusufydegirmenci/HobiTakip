using System;

namespace HobiTakip.Models
{
    public class UserAchievement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AchievementId { get; set; }
        public DateTime UnlockedDate { get; set; }
        public bool IsNew { get; set; } = true; // Yeni rozet bildirimi için
    }
}
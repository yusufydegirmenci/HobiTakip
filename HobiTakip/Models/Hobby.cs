using System;

namespace HobiTakip.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public string DifficultyLevel { get; set; } = string.Empty; // Kolay, Orta, Zor
        public int TotalTimeSpent { get; set; } // dakika cinsinden
        public DateTime CreatedDate { get; set; }
    }
}
using System;

namespace HobiTakip.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public int HobbyId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime TargetDate { get; set; }
        public int TargetValue { get; set; } // Hedef değer (saat, sayfa, km vb.)
        public string Unit { get; set; } = string.Empty; // Birim (saat, sayfa, km)
        public int CurrentValue { get; set; } // Mevcut değer
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        
        public double ProgressPercentage => TargetValue > 0 ? (double)CurrentValue / TargetValue * 100 : 0;
    }
}
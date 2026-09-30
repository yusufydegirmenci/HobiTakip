using System;

namespace HobiTakip.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public int HobbyId { get; set; }
        public int? GoalId { get; set; } // Opsiyonel - hedefe bağlı olmayan aktiviteler için
        public DateTime Date { get; set; }
        public int TimeSpent { get; set; } // dakika cinsinden
        public int Value { get; set; } // Yapılan iş miktarı
        public string Unit { get; set; } = string.Empty; // Birim
        public string Notes { get; set; } = string.Empty;
        public int Rating { get; set; } // 1-5 arası memnuniyet
        public DateTime CreatedDate { get; set; }
    }
}
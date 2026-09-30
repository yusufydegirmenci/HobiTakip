using System;

namespace HobiTakip.Models
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty; // Emoji veya simge
        public string Category { get; set; } = string.Empty; // İlk Adımlar, Süreklilik, Başarı vb.
        public int RequiredValue { get; set; } // Gerekli değer (saat, gün, adet)
        public string RequirementType { get; set; } = string.Empty; // "TotalHours", "Streak", "Goals" vb.
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }
    }
}
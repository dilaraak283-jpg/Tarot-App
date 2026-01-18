using System;
using System.Drawing;

namespace TarotFalApp
{
    public class TarotCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; } // Resources'taki isimle birebir aynı olmalı
        public bool IsReversed { get; set; }

        // --- Kategorik Anlamlar ---
        public string GeneralUpright { get; set; }
        public string GeneralReversed { get; set; }
        public string LoveUpright { get; set; }
        public string LoveReversed { get; set; }
        public string CareerUpright { get; set; }
        public string CareerReversed { get; set; }

        // Kategoriye ve yönüne göre anlamı getiren fonksiyon
        public string GetMeaning(string category)
        {
            if (category == "Aşk")
                return IsReversed ? LoveReversed : LoveUpright;
            else if (category == "Kariyer")
                return IsReversed ? CareerReversed : CareerUpright;
            else
                return IsReversed ? GeneralReversed : GeneralUpright;
        }

        // Kartın Major Arcana olup olmadığını kontrol eder (0-22 arası)
        public bool IsMajorArcana => Id >= 0 && Id <= 22;
    }
}
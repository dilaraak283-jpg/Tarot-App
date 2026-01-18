using System.Collections.Generic;

namespace TarotFalApp
{
    public static class SpreadManager
    {
        public static List<ISpread> GetSpreadsByCategory(string category)
        {
            var list = new List<ISpread>();
            switch (category)
            {
                case "Aşk":
                    list.Add(new LoveSpread("Tek Kart - Tek Cevap", 1));
                    list.Add(new LoveSpread("Üç Kart", 3));
                    list.Add(new LoveSpread("İlişki Analizi (5 Kart)", 5));
                    break;
                case "Kariyer":
                    list.Add(new CareerSpread("Yol Ayrımı (Tek Kart)", 1));
                    list.Add(new CareerSpread("Karar Açılımı (3 Kart)", 3));
                    break;
                case "Genel":
                    list.Add(new GeneralSpread());
                    break;
            }
            return list;
        }
    }
}

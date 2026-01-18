namespace TarotFalApp
{
    public class GeneralSpread : BaseSpread
    {
        public override string SpreadName => "Öngörü (3 Kart)";
        public override int CardCount => 3;
        public override string Category => "Genel";

        public override void Interpret() { /* Genel yorum mantığı */ }
    }
}
namespace TarotFalApp
{
    public class LoveSpread : BaseSpread
    {
        private readonly string _name;
        private readonly int _count;

        public LoveSpread(string name, int count)
        {
            _name = name;
            _count = count;
        }

        public override string SpreadName => _name;
        public override int CardCount => _count;
        public override string Category => "Aşk";

        public override void Interpret()
        {
            // Aşk yorumu mantığı buraya gelecek
        }
    }
}
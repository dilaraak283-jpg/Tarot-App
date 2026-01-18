namespace TarotFalApp
{
    public class CareerSpread : BaseSpread
    {
        private readonly string _name;
        private readonly int _count;

        public CareerSpread(string name, int count)
        {
            _name = name;
            _count = count;
        }

        public override string SpreadName => _name;
        public override int CardCount => _count;
        public override string Category => "Kariyer";

        public override void Interpret() { /* Kariyer yorum mantığı */ }
    }
}
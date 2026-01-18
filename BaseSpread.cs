using System.Collections.Generic;

namespace TarotFalApp
{
    public abstract class BaseSpread : ISpread
    {
        public abstract string SpreadName { get; }
        public abstract int CardCount { get; }
        public abstract string Category { get; }
        public List<string> SelectedCards { get; set; } = new List<string>();

        
        public abstract void Interpret();
    }
}
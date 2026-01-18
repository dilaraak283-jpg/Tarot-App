using System.Collections.Generic;

namespace TarotFalApp
{
    public interface ISpread
    {
        string SpreadName { get; }
        int CardCount { get; }
        string Category { get; }
        List<string> SelectedCards { get; set; }
        void Interpret(); 
    }
}
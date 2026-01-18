using System.Collections.Generic;
using TarotFalApp;

public static class AppState
{
    public static string SelectedDeckType { get; set; }
    public static string SelectedCategory { get; set; }
    public static List<TarotCard> SelectedCards { get; set; } = new List<TarotCard>();
}
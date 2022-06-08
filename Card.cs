class Card
{
    public string Name;
    public string Suit;
    public int Val;

    public Card(string suit, int val)
    {
        if (val == 11) {
            Name = "Jack";
        } else if (val == 12) {
            Name = "Queen";
        } else if (val == 13) {
            Name = "King";
        } else if (val == 1) {
            Name = "Ace";
        } else {
            Name = val.ToString();
        }
        Suit = suit;
        Val = val;
    }

    public void Print()
    {
        System.Console.WriteLine($"Name: {this.Name}");
        System.Console.WriteLine($"Val: {this.Val}");
        System.Console.WriteLine($"Name: {this.Suit}");
    }
}
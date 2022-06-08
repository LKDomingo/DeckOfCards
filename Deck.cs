class Deck
{
    public List<Card> cards = new List<Card>();

    public Deck()
    {
        Reset();
    }
    public List<Card> Reset()
    {
        cards.Clear();

        string[] suits =
        {
            "Hearts",
            "Diamonds",
            "Spades",
            "Clubs"
        };

        foreach (string suit in suits)
        {
            for (int i = 1; i < 14; i++)
            {
                Card newCard = new Card(suit, i);
                cards.Add(newCard);
                // Console.WriteLine($"{newCard.Name} of {newCard.Suit}");
            }
        }
        return cards;
    }

    public Card Deal()
    {
        Card removedCard = cards[cards.Count - 1];
        // System.Console.WriteLine($"{removedCard.Name} of {removedCard.Suit}");
        cards.RemoveAt(cards.Count - 1);

        return removedCard;
    }

    public void Shuffle()
    {
        Random rand = new Random();
        // create new shuffled cards list
        List<Card> shuffledCards = new List<Card>();

        for (int i = 0; i < this.cards.Count; i++)
        {
            int randomNum = rand.Next(this.cards.Count);
            shuffledCards.Add(this.cards[randomNum]);
            this.cards.RemoveAt(randomNum);
        }
        cards = shuffledCards;


    }
}
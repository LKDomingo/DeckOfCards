class Player 
{
    public string Name;
    public List<Card> Hand;

    public Player(string name)
    {
        Name = name;
        Hand = new List<Card>();
    }

    public Card Draw(Deck deck)
    {
        Card newCard = deck.Deal();
        Hand.Add(newCard);
        System.Console.WriteLine($"You drew the {newCard.Name} of {newCard.Suit} from the deck.");
        
        return newCard;
    }

    public Card Discard(int idx)
    {
        if(Hand[idx] != null)
        {
            Card removedCard = Hand[idx];
            Hand.RemoveAt(idx);

            return removedCard;
        } else {
            return null!;
        }
    }

    public void PrintHand() 
    {
        System.Console.WriteLine("Your Hand:");
        foreach (Card card in this.Hand)
        {
            System.Console.WriteLine($"{card.Name} of {card.Suit}");
        }
    }



}
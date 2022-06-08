Card card = new Card("Hearts", 12);

Deck deck = new Deck();

Player me = new Player("Logan");

deck.Shuffle();
deck.Deal();

me.Draw(deck);
me.Draw(deck);
me.Draw(deck);
me.PrintHand();
me.Discard(1);
me.PrintHand();




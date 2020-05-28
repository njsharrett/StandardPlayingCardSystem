using System;

public class Card
{
	//may not be necessary since we don't need to compare suits yet
	enum Suits
    {
		Hearts,
		Diamonds,
		Clubs,
		Spades
    }

	enum Values
    {
		Jack = 11,
		Queen,
		King,
		Ace
    }

	int suit;
	int value;

	public Card()
	{
	}
}

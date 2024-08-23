namespace PickRandomCards;

internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }
        return pickedCards;
    }

    public static string RandomSuit()
    {
        int value = Random.Shared.Next(1, 5);

        string suit = value switch
        {
            1 => "Hearts",
            2 => "Clubs",
            3 => "Spades",
            _ => "Diamonds",
        };

        return suit;
    }

    public static string RandomValue()
    {
        int value = Random.Shared.Next(1,14);
        string card = value switch
        {
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => value.ToString(),
        };
        return card;
    }
}

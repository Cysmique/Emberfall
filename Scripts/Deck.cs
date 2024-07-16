using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<CardData> cards = new List<CardData>();

    public void ShuffleDeck()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            CardData temp = cards[i];
            int randomIndex = Random.Range(i, cards.Count);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }
    }

    public CardData DrawCard()
    {
        if (cards.Count > 0)
        {
            CardData drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }
        return null;
    }
}
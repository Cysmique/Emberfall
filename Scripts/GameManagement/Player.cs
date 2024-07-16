// Player.cs
using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    private List<Card> deck;

    public Player()
    {
        deck = new List<Card>();
    }

    private void Start()
    {
        deck = new List<Card>();
        foreach (var cardData in PlayerData.Instance.GetCurrentDeck())
        {
            Card newCard = new GameObject("Card").AddComponent<Card>();
            newCard.Initialize(cardData);
            deck.Add(newCard);
        }
    }

    public virtual void StartTurn()
    {
        // Start turn logic here
    }
}

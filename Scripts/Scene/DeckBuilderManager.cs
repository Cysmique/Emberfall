// DeckBuilderManager.cs
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilderManager : MonoBehaviour
{
    private List<CardData> deck;

    private void Start()
    {
        LoadDeck();
    }

    public void LoadDeck()
    {
        deck = PlayerData.Instance.GetCurrentDeck();
        // Load deck logic here
    }

    public void SaveDeck()
    {
        // Current deck state logic here
        PlayerData.Instance.SetCurrentDeck(deck);
    }
}

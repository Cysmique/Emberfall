// PlayerData.cs
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    private static PlayerData _instance;
    public static PlayerData Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<PlayerData>("PlayerData");
            }
            return _instance;
        }
    }

    public List<CardData> deck;
    public int health;
    public int mana;

    public List<CardData> GetCurrentDeck()
    {
        return deck;
    }

    public void SetCurrentDeck(List<CardData> newDeck)
    {
        deck = newDeck;
    }
}

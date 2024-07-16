using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CardDatabase", menuName = "Emberfall/Card Database")]
public class CardDatabase : ScriptableObject
{
    public List<CardData> allCards = new List<CardData>();

    public CardData GetCardById(int id)
    {
        return allCards.Find(card => card.id == id);
    }

    public List<CardData> GetCardsByElement(CardData.ElementType elementType)
    {
        return allCards.FindAll(card => card.elementType == elementType);
    }

    public List<CardData> GetCardsByRarity(CardData.CardRarity rarity)
    {
        return allCards.FindAll(card => card.rarity == rarity);
    }

    public List<CardData> GetCardsByManaCost(int manaCost)
    {
        return allCards.FindAll(card => card.manaCost == manaCost);
    }
}
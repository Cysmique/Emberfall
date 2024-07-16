using System.Collections.Generic;
using UnityEngine;

public class CardLoader : MonoBehaviour
{
    public List<CardData> allCards;

    [System.Serializable]
    public class JsonCardData
    {
        public int id;
        public string cardName;
        public string description;
        public int manaCost;
        public int attack;
        public int health;
        public string elementType;
        public string rarity;
        public string[] abilityNames;
    }

    public void LoadCards(string json)
    {
        JsonCardData[] jsonCards = JsonHelper.FromJson<JsonCardData>(json);
        foreach (JsonCardData jsonCard in jsonCards)
        {
            CardData card = ScriptableObject.CreateInstance<CardData>();
            card.id = jsonCard.id;
            card.cardName = jsonCard.cardName;
            card.description = jsonCard.description;
            card.manaCost = jsonCard.manaCost;
            card.attack = jsonCard.attack;
            card.health = jsonCard.health;

            switch (jsonCard.elementType)
            {
                case "Fire":
                    card.elementType = CardData.ElementType.Fire;
                    break;
                case "Ice":
                    card.elementType = CardData.ElementType.Ice;
                    break;
                case "Nature":
                    card.elementType = CardData.ElementType.Nature;
                    break;
                case "Neutral":
                    card.elementType = CardData.ElementType.Neutral;
                    break;
            }

            switch (jsonCard.rarity)
            {
                case "Common":
                    card.rarity = CardData.CardRarity.Common;
                    break;
                case "Rare":
                    card.rarity = CardData.CardRarity.Rare;
                    break;
                case "Epic":
                    card.rarity = CardData.CardRarity.Epic;
                    break;
                case "Legendary":
                    card.rarity = CardData.CardRarity.Legendary;
                    break;
            }

            card.abilityNames = new List<string>(jsonCard.abilityNames);
            allCards.Add(card);
        }
    }
}

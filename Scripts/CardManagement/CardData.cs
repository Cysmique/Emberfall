using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Card", menuName = "Emberfall/Card")]
public class CardData : ScriptableObject
{
    public int id;
    public string cardName;
    public string description;
    public Sprite artwork;
    public int manaCost;
    public int attack;
    public int health;
    public ElementType elementType;
    public CardRarity rarity;
    public List<string> abilityNames;

    public enum ElementType
    {
        Fire,
        Ice,
        Nature,
        Neutral
    }

    public enum CardRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }
}

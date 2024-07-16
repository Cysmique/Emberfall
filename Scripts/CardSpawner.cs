using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public CardLoader cardLoader;
    public GameObject cardPrefab; // Kart prefab'�n�z� burada tan�mlay�n

    void Start()
    {
        List<CardData> cardsToSpawn = cardLoader.allCards;
        foreach (CardData card in cardsToSpawn)
        {
            GameObject cardObject = Instantiate(cardPrefab, transform);
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(card);
        }
    }
}

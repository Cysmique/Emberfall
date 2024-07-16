using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public CardLoader cardLoader;
    public TextAsset jsonFile; // JSON dosyas�n� buraya atay�n
    public Transform handTransform; // Kartlar� g�sterece�imiz UI alan�
    public GameObject cardPrefab; // Kart prefab�

    private List<CardData> playerDeck;

    void Start()
    {
        if (jsonFile != null)
        {
            cardLoader.LoadCards(jsonFile.text);
            playerDeck = cardLoader.allCards;
            DisplayCards();
        }
        else
        {
            Debug.LogError("JSON file is missing!");
        }
    }

    void DisplayCards()
    {
        foreach (CardData cardData in playerDeck)
        {
            GameObject cardObject = Instantiate(cardPrefab, handTransform);
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(cardData);
            cardDisplay.gameController = this; // gameController referans�n� ayarlay�n
        }
    }

    public void PlayCard(CardData cardData)
    {
        // �u anda sadece kart�n ad�n� konsola yazd�r�r
        Debug.Log("Playing card: " + cardData.cardName);
        // Buraya kart oynama mant���n� ekleyin
    }
}

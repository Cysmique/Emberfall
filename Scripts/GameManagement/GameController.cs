using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public CardLoader cardLoader;
    public TextAsset jsonFile; // JSON dosyasýný buraya atayýn
    public Transform handTransform; // Kartlarý göstereceðimiz UI alaný
    public GameObject cardPrefab; // Kart prefabý

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
            cardDisplay.gameController = this; // gameController referansýný ayarlayýn
        }
    }

    public void PlayCard(CardData cardData)
    {
        // Þu anda sadece kartýn adýný konsola yazdýrýr
        Debug.Log("Playing card: " + cardData.cardName);
        // Buraya kart oynama mantýðýný ekleyin
    }
}

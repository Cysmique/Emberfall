using System.Collections.Generic;
using UnityEngine;

public class BoardDisplay : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform cardParent;
    private List<GameObject> activeCards = new List<GameObject>();

    public void DisplayCards(List<CardData> cards)
    {
        // Önceki kartlarý temizle
        foreach (GameObject card in activeCards)
        {
            Destroy(card);
        }
        activeCards.Clear();

        // Yeni kartlarý ekle
        foreach (CardData cardData in cards)
        {
            GameObject cardObject = Instantiate(cardPrefab, cardParent);
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(cardData); // UpdateDisplay yerine SetCardData kullanýyoruz
            activeCards.Add(cardObject);
        }
    }
}

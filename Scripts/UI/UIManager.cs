using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Transform handTransform;
    public Transform boardTransform;
    public GameObject cardPrefab;

    public void UpdateHandDisplay(List<CardData> handCards)
    {
        foreach (Transform child in handTransform)
        {
            Destroy(child.gameObject);
        }

        foreach (CardData card in handCards)
        {
            GameObject cardObject = Instantiate(cardPrefab, handTransform);
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(card);
        }
    }

    public void UpdateBoardDisplay(List<CardData> boardCards)
    {
        foreach (Transform child in boardTransform)
        {
            Destroy(child.gameObject);
        }

        foreach (CardData card in boardCards)
        {
            GameObject cardObject = Instantiate(cardPrefab, boardTransform);
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(card);
        }
    }
}

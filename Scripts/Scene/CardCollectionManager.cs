using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CardCollectionManager : MonoBehaviour
{
    public Transform cardContainer;
    public Button backButton;

    private List<CardData> allCards;

    private void Start()
    {
        allCards = DataManager.Instance.GetAllCards();
        DisplayCards();

        backButton.onClick.AddListener(ReturnToMainMenu);
    }

    private void DisplayCards()
    {
        foreach (var cardData in allCards)
        {
            // Kart prefab'ýný oluþtur ve cardContainer'a ekle
        }
    }

    private void ReturnToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI manaCostText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;
    public Image artworkImage;

    public GameController gameController; // Referans

    private CardData cardData;

    public void SetCardData(CardData data)
    {
        cardData = data;
        nameText.text = cardData.cardName;
        descriptionText.text = cardData.description;
        manaCostText.text = cardData.manaCost.ToString();
        attackText.text = cardData.attack.ToString();
        healthText.text = cardData.health.ToString();
        artworkImage.sprite = cardData.artwork;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            gameController.PlayCard(cardData);
        }
    }
}

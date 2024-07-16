using UnityEngine;

public class CardFactory : MonoBehaviour
{
    public static CardFactory Instance { get; private set; }

    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private CardDatabase cardDatabase;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Card CreateCard(int cardId)
    {
        CardData cardData = cardDatabase.GetCardById(cardId);
        if (cardData == null)
        {
            Debug.LogError($"Card with ID {cardId} not found in database.");
            return null;
        }

        GameObject cardObject = Instantiate(cardPrefab);
        Card card = cardObject.GetComponent<Card>();
        card.Initialize(cardData);

        return card;
    }
}

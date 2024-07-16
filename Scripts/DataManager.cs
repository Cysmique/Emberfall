using UnityEngine;
using System.Collections.Generic;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    [SerializeField] private CardDatabase cardDatabase;

    private Dictionary<int, CardData> cardDictionary = new Dictionary<int, CardData>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadAllData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoadAllData()
    {
        LoadCardData();
        // Diðer veri yükleme iþlemleri buraya eklenebilir
    }

    private void LoadCardData()
    {
        foreach (CardData card in cardDatabase.allCards)
        {
            cardDictionary[card.id] = card;
        }
    }

    public CardData GetCardById(int id)
    {
        if (cardDictionary.TryGetValue(id, out CardData card))
        {
            return card;
        }
        Debug.LogWarning($"Card with id {id} not found.");
        return null;
    }

    public List<CardData> GetAllCards()
    {
        return new List<CardData>(cardDictionary.Values);
    }
}
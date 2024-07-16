using UnityEngine;
using TMPro;

public class DeckCountDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text countText;

    public void UpdateCount(int count)
    {
        countText.text = $"Deck: {count}";
    }
}
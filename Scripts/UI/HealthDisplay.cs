using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text healthText;

    public void UpdateHealth(int health)
    {
        healthText.text = $"HP: {health}";
    }
}
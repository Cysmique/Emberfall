using UnityEngine;
using TMPro;

public class ManaDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text manaText;

    public void UpdateMana(int mana)
    {
        manaText.text = $"Mana: {mana}";
    }
}
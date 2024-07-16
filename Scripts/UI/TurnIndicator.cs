using UnityEngine;
using TMPro;

public class TurnIndicator : MonoBehaviour
{
    [SerializeField] private TMP_Text turnText;

    public void SetTurn(bool isPlayerTurn)
    {
        turnText.text = isPlayerTurn ? "Your Turn" : "AI's Turn";
    }
}
// CardState.cs
using UnityEngine;

public class CardState : MonoBehaviour
{
    public void ChangeCardState(Card card, string newState)
    {
        card.ChangeState(newState);
    }
}

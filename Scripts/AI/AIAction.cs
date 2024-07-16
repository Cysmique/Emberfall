// AIAction.cs
using UnityEngine;

public class AIAction : MonoBehaviour
{
    public void PerformAction(Card attacker, Card target)
    {
        attacker.Attack(target);
    }
}

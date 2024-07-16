// BattleAnimationManager.cs
using UnityEngine;

public class BattleAnimationManager : MonoBehaviour
{
    public void PlayAttackAnimation(Card attacker, Card target)
    {
        attacker.Attack(target);
        // Animasyon kodu burada olacak
    }
}

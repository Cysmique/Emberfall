using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public void ResolveBattle(Card attacker, Card defender)
    {
        int damage = DamageCalculator.CalculateDamage(attacker, defender);
        defender.TakeDamage(damage);

        if (defender.IsDead())
        {
            defender.Die();
        }

        int counterDamage = DamageCalculator.CalculateDamage(defender, attacker);
        attacker.TakeDamage(counterDamage);

        if (attacker.IsDead())
        {
            attacker.Die();
        }
    }
}

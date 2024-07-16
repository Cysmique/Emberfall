using UnityEngine;

public static class DamageCalculator
{
    public static int CalculateDamage(Card attacker, Card defender)
    {
        float multiplier = GetElementMultiplier(attacker.Data.elementType, defender.Data.elementType);
        int damage = Mathf.RoundToInt(attacker.Data.attack * multiplier);
        return damage;
    }

    public static float GetElementMultiplier(CardData.ElementType attackerElement, CardData.ElementType defenderElement)
    {
        // Element multiplier logic here
        return 1.0f;
    }
}

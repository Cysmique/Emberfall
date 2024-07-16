using UnityEngine;

public class ElementInteractionManager : MonoBehaviour
{
    public static ElementInteractionManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ApplyElementalInteraction(Card attacker, Card defender)
    {
        float effectiveness = DamageCalculator.GetElementMultiplier(attacker.Data.elementType, defender.Data.elementType);
        int damage = Mathf.RoundToInt(attacker.Data.attack * effectiveness);

        defender.TakeDamage(damage);

        if (effectiveness > 1.0f)
        {
            Debug.Log($"{attacker.Data.name} dealt super effective damage to {defender.Data.name}!");
        }
        else if (effectiveness < 1.0f)
        {
            Debug.Log($"{attacker.Data.name}'s attack was not very effective against {defender.Data.name}.");
        }
    }
}

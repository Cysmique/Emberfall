using UnityEngine;
using System.Collections.Generic;

public class AbilitySystem : MonoBehaviour
{
    public static AbilitySystem Instance { get; private set; }

    private Dictionary<string, System.Func<Card, Card, bool>> abilityFunctions;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeAbilities();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializeAbilities()
    {
        abilityFunctions = new Dictionary<string, System.Func<Card, Card, bool>>
        {
            { "Fireball", Fireball },
            { "Freeze", Freeze },
            { "Heal", Heal }
            // Diðer yetenekler buraya eklenebilir
        };
    }

    public bool ExecuteAbility(string abilityName, Card source, Card target)
    {
        if (abilityFunctions.TryGetValue(abilityName, out var abilityFunction))
        {
            return abilityFunction(source, target);
        }
        else
        {
            Debug.LogWarning($"Ability not found: {abilityName}");
            return false;
        }
    }

    private bool Fireball(Card source, Card target)
    {
        int damage = 3;
        target.TakeDamage(damage);
        Debug.Log($"{source.Data.cardName} used Fireball on {target.Data.cardName} for {damage} damage!");
        return true;
    }

    private bool Freeze(Card source, Card target)
    {
        var freezeEffect = ScriptableObject.CreateInstance<FreezeEffect>();
        freezeEffect.duration = 2; // 2 tur boyunca dondurur
        target.ApplyStatusEffect(freezeEffect);
        Debug.Log($"{source.Data.cardName} froze {target.Data.cardName} for {freezeEffect.duration} turns!");
        return true;
    }

    private bool Heal(Card source, Card target)
    {
        int healAmount = 2;
        target.Heal(healAmount);
        Debug.Log($"{source.Data.cardName} healed {target.Data.cardName} for {healAmount} health!");
        return true;
    }
}

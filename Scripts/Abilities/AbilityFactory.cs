using UnityEngine;
using System;

public class AbilityFactory : MonoBehaviour
{
    public static AbilityFactory Instance { get; private set; }

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

    public IAbility CreateAbility(string abilityName)
    {
        switch (abilityName)
        {
            case "Fireball":
                return new FireballAbility();
            case "Freeze":
                return new FreezeAbility();
            case "Heal":
                return new HealAbility();
            // Diðer yetenekler buraya eklenebilir
            default:
                Debug.LogWarning($"Unknown ability: {abilityName}");
                return null;
        }
    }
}

public interface IAbility
{
    bool Execute(Card source, Card target);
}

public class FireballAbility : IAbility
{
    public bool Execute(Card source, Card target)
    {
        return AbilitySystem.Instance.ExecuteAbility("Fireball", source, target);
    }
}

public class FreezeAbility : IAbility
{
    public bool Execute(Card source, Card target)
    {
        return AbilitySystem.Instance.ExecuteAbility("Freeze", source, target);
    }
}

public class HealAbility : IAbility
{
    public bool Execute(Card source, Card target)
    {
        return AbilitySystem.Instance.ExecuteAbility("Heal", source, target);
    }
}
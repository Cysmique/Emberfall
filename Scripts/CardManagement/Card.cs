// Card.cs
using UnityEngine;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    public CardData Data { get; private set; }
    private int currentHealth;

    public void Initialize(CardData data)
    {
        Data = data;
        currentHealth = data.health;

        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = data.artwork;

        foreach (string abilityName in data.abilityNames)
        {
            IAbility ability = AbilityFactory.Instance.CreateAbility(abilityName);
            if (ability != null)
            {
                // Add the ability to the card
            }
        }
    }

    public void Attack(Card target)
    {
        // Attack logic
    }

    public void ChangeState(string newState)
    {
        // Change state logic
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, Data.health);
    }

    public void ApplyStatusEffect(StatusEffect effect)
    {
        // Apply status effect
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }

    public void Die()
    {
        // Play death animation
        GetComponent<CardAnimator>().PlayDestroyAnimation();

        // Remove the card from the game area
        Destroy(gameObject, 1f); // Wait for the animation duration
    }
}

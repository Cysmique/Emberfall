using UnityEngine;

public abstract class StatusEffect : ScriptableObject
{
    public string effectName;
    public int duration;

    public abstract void ApplyEffect(Card target);
    public abstract void RemoveEffect(Card target);
}

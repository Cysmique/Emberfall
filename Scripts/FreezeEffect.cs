using UnityEngine;

[CreateAssetMenu(fileName = "New Freeze Effect", menuName = "Emberfall/StatusEffects/FreezeEffect")]
public class FreezeEffect : StatusEffect
{
    public override void ApplyEffect(Card target)
    {
        // Donma etkisini uygula
        Debug.Log($"{target.Data.cardName} has been frozen for {duration} turns!");
    }

    public override void RemoveEffect(Card target)
    {
        // Donma etkisini kaldýr
        Debug.Log($"{target.Data.cardName} is no longer frozen!");
    }
}

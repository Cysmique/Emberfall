using UnityEngine;

public class EffectAnimator : MonoBehaviour
{
    [SerializeField] private ParticleSystem damageEffect;
    [SerializeField] private ParticleSystem healEffect;
    [SerializeField] private ParticleSystem shieldEffect;

    public void PlayDamageEffect(Vector3 position)
    {
        PlayEffect(damageEffect, position);
    }

    public void PlayHealEffect(Vector3 position)
    {
        PlayEffect(healEffect, position);
    }

    public void PlayShieldEffect(Vector3 position)
    {
        PlayEffect(shieldEffect, position);
    }

    private void PlayEffect(ParticleSystem effect, Vector3 position)
    {
        ParticleSystem instance = Instantiate(effect, position, Quaternion.identity);
        Destroy(instance.gameObject, instance.main.duration);
    }
}
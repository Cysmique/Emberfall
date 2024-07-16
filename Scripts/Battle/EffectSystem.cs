using UnityEngine;

public class EffectSystem : MonoBehaviour
{
    public static EffectSystem Instance { get; private set; }

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

    public void ApplyBattleEffects(Card attacker, Card defender)
    {
        // Battle effects logic here
    }
}

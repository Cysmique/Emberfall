using UnityEngine;
using System.Collections.Generic;

public class ElementSystem : MonoBehaviour
{
    public static ElementSystem Instance { get; private set; }

    public enum ElementType
    {
        Fire,
        Ice,
        Nature,
        Neutral
    }

    private Dictionary<ElementType, float> elementEffectiveness = new Dictionary<ElementType, float>
    {
        { ElementType.Fire, 1.5f },
        { ElementType.Ice, 1.5f },
        { ElementType.Nature, 1.5f },
        { ElementType.Neutral, 1.0f }
    };

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

    public float GetElementalEffectiveness(ElementType attackerElement, ElementType defenderElement)
    {
        if (attackerElement == ElementType.Fire && defenderElement == ElementType.Nature)
            return elementEffectiveness[ElementType.Fire];
        if (attackerElement == ElementType.Ice && defenderElement == ElementType.Fire)
            return elementEffectiveness[ElementType.Ice];
        if (attackerElement == ElementType.Nature && defenderElement == ElementType.Ice)
            return elementEffectiveness[ElementType.Nature];

        return 1.0f; // Nötr etkileþim
    }
}
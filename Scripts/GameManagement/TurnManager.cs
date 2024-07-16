// TurnManager.cs
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.botController.ControlBot();
    }
}

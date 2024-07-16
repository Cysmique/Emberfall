// BattleSceneManager.cs
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = new GameObject("Player").AddComponent<Player>();
        // Additional initialization code here
    }
}

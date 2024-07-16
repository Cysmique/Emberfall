using UnityEngine;

public class AIDifficultyManager : MonoBehaviour
{
    public enum Difficulty { Easy, Normal, Hard }

    public Difficulty currentDifficulty = Difficulty.Normal;

    public void SetDifficulty(Difficulty difficulty)
    {
        currentDifficulty = difficulty;
        UpdateAIBehavior();
    }

    private void UpdateAIBehavior()
    {
        AIDecisionMaker decisionMaker = GetComponent<AIDecisionMaker>();
        switch (currentDifficulty)
        {
            case Difficulty.Easy:
                // Kolay zorluk seviyesi i�in AI davran��lar�n� ayarla
                break;
            case Difficulty.Normal:
                // Normal zorluk seviyesi i�in AI davran��lar�n� ayarla
                break;
            case Difficulty.Hard:
                // Zor zorluk seviyesi i�in AI davran��lar�n� ayarla
                break;
        }
    }
}
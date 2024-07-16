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
                // Kolay zorluk seviyesi için AI davranýþlarýný ayarla
                break;
            case Difficulty.Normal:
                // Normal zorluk seviyesi için AI davranýþlarýný ayarla
                break;
            case Difficulty.Hard:
                // Zor zorluk seviyesi için AI davranýþlarýný ayarla
                break;
        }
    }
}
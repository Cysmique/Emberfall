using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public void PlayCardPlace()
    {
        AudioManager.Instance.Play("CardPlace");
    }

    public void PlayCardAttack()
    {
        AudioManager.Instance.Play("CardAttack");
    }

    public void PlayCardDestroy()
    {
        AudioManager.Instance.Play("CardDestroy");
    }

    public void PlayButtonClick()
    {
        AudioManager.Instance.Play("ButtonClick");
    }

    public void PlayVictory()
    {
        AudioManager.Instance.Play("Victory");
    }

    public void PlayDefeat()
    {
        AudioManager.Instance.Play("Defeat");
    }

    // Diðer ses efektleri için metodlar eklenebilir
}
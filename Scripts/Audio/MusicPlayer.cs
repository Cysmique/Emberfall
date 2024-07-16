using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private string mainMenuMusicName = "MainMenuTheme";
    [SerializeField] private string battleMusicName = "BattleTheme";
    [SerializeField] private string victoryMusicName = "VictoryTheme";
    [SerializeField] private string defeatMusicName = "DefeatTheme";

    private string currentMusicName;

    private void Start()
    {
        PlayMainMenuMusic();
    }

    public void PlayMainMenuMusic()
    {
        PlayMusic(mainMenuMusicName);
    }

    public void PlayBattleMusic()
    {
        PlayMusic(battleMusicName);
    }

    public void PlayVictoryMusic()
    {
        PlayMusic(victoryMusicName);
    }

    public void PlayDefeatMusic()
    {
        PlayMusic(defeatMusicName);
    }

    private void PlayMusic(string musicName)
    {
        if (currentMusicName == musicName) return;

        if (!string.IsNullOrEmpty(currentMusicName))
        {
            AudioManager.Instance.Stop(currentMusicName);
        }

        AudioManager.Instance.Play(musicName);
        currentMusicName = musicName;
    }

    public void SetMusicVolume(float volume)
    {
        if (!string.IsNullOrEmpty(currentMusicName))
        {
            AudioManager.Instance.SetVolume(currentMusicName, volume);
        }
    }
}
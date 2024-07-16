using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button deckBuilderButton;
    [SerializeField] private Button cardCollectionButton;
    // [SerializeField] private Button optionsButton; // Geçici olarak kaldýrýldý
    [SerializeField] private Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(StartGame);
        deckBuilderButton.onClick.AddListener(OpenDeckBuilder);
        cardCollectionButton.onClick.AddListener(OpenCardCollection);
        // optionsButton.onClick.AddListener(OpenOptions); // Geçici olarak kaldýrýldý
        exitButton.onClick.AddListener(ExitGame);

        // Ana menü müziðini baþlat
        // AudioManager.Instance.Play("MainMenuTheme"); // Eðer bu satýr hata veriyorsa
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Battle");
    }

    private void OpenDeckBuilder()
    {
        SceneManager.LoadScene("DeckBuilder");
    }

    private void OpenCardCollection()
    {
        SceneManager.LoadScene("CardCollection");
    }

    // private void OpenOptions() // Geçici olarak kaldýrýldý
    // {
    //     // Ayarlar menüsünü aç (UI panel veya yeni sahne)
    // }

    private void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

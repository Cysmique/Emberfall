using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button deckBuilderButton;
    [SerializeField] private Button cardCollectionButton;
    // [SerializeField] private Button optionsButton; // Ge�ici olarak kald�r�ld�
    [SerializeField] private Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(StartGame);
        deckBuilderButton.onClick.AddListener(OpenDeckBuilder);
        cardCollectionButton.onClick.AddListener(OpenCardCollection);
        // optionsButton.onClick.AddListener(OpenOptions); // Ge�ici olarak kald�r�ld�
        exitButton.onClick.AddListener(ExitGame);

        // Ana men� m�zi�ini ba�lat
        // AudioManager.Instance.Play("MainMenuTheme"); // E�er bu sat�r hata veriyorsa
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

    // private void OpenOptions() // Ge�ici olarak kald�r�ld�
    // {
    //     // Ayarlar men�s�n� a� (UI panel veya yeni sahne)
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

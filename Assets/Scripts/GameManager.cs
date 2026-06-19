using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverPanel;
    public AudioClip gameOverSound;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI highScoreText;
    private AudioSource audioSource;
    void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    public void GameOver()
    {
        StartCoroutine(GameOverRoutine());
    }
    IEnumerator GameOverRoutine()
    {
        if (gameOverSound != null)
        {
            audioSource.PlayOneShot(gameOverSound);
        }
        CameraFollow cam = Camera.main.GetComponent<CameraFollow>();
        if (cam != null)
        {
            cam.Shake(0.5f, 1f);
        }
        yield return new WaitForSecondsRealtime(0.5f);
        int score = (int)Time.timeSinceLevelLoad;
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        finalScoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverPanel;
    void Awake()
    {
        instance = this;
    }
    public void GameOver()
    {
     Debug.Log("GameManager: " + gameObject.name);
     Debug.Log("Panel: " + gameOverPanel);
     Time.timeScale = 0f;
     if (gameOverPanel != null)
     {
      gameOverPanel.SetActive(true);
     }
     else
    {
     Debug.LogError("Game Over Panel is NULL!");
     }
    }
    public void RestartGame()
    {
     Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
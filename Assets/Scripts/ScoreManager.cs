using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Update()
    {
        int score = (int)Time.timeSinceLevelLoad;
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;

        }
        scoreText.text = "Score: " + score + "\nHigh Score: " + highScore;

    }
}
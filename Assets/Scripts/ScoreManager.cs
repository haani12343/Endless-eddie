
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Update()
    {
        int score = (int)Time.timeSinceLevelLoad;
        scoreText.text = "Score: " + score;

    }
}
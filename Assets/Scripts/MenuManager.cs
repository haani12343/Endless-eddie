using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PLAY BUTTON CLICKED");
        SceneManager.LoadScene("v");

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");

    }
}
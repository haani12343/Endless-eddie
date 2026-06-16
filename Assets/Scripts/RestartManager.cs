using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
 void Update()
    {
     if (Input.GetKeyDown(KeyCode.R))
     {
    Time.timeScale = 1;
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } }
}
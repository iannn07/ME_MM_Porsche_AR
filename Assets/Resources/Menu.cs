using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ARCam");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("UI");
    }
}

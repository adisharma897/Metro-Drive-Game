using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject PM;
    public static bool isMenuPaused = false;

    public void PauseMenu()
    {
        if(isMenuPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        PM.SetActive(false);
        Time.timeScale = 1f;
        isMenuPaused = false;
    }

    void Pause()
    {
        PM.SetActive(true);
        Time.timeScale = 0f;
        isMenuPaused = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }

    public void MainGame()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

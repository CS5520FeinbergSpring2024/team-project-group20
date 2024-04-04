using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

        //stop timer
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

        // start timer
    }

    public void Restart()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

    }
}

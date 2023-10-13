using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused;

    public GameObject pauseMenuUI;


    private void Start()
    {
        gameIsPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;

            }
            else
            {
                Pause();
                Cursor.lockState = CursorLockMode.None;
            }

        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //public void LoadMenu()
    //{
    //    gameIsPaused = false;
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("Menu");
    //}

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();

    }
}

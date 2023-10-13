using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winUI : MonoBehaviour
{
    

    public static bool GameIsWon = false;
    public GameObject pauseMenu;

    public GameObject WinUI;

    void Start()
    {
        //pauseMenu.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    //public void LoadMenu()
    //{
    //    GameIsWon = false;
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("Menu");
    //}

    //public void QuitGame()
    //{
    //    Debug.Log("Quitting Game");
    //    Application.Quit();

    //}

}

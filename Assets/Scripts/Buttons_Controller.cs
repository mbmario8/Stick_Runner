using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons_Controller : MonoBehaviour
{

    

    public void pause()
    {
        Time.timeScale = 0f;
    }

    public void resume()
    {
        Time.timeScale = 1f;
    }

    public void exit()
    {
        Application.Quit();

    }

    //LLvl01 Button
    public void Play()
    {
        SceneManager.LoadScene("Lvl01");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}

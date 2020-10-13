using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Controller : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Lvl01");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void pause()
    {
        Time.timeScale = 0;
    }

}

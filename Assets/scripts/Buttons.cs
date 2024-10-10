using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("PlayMode");
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void CreativeMode()
    {
        SceneManager.LoadScene("CreativeMode");
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1;
    }
    public void ArenaMode1()
    {
        SceneManager.LoadScene("SampleScene 1");
        Time.timeScale = 1;
    }
    public void Tank()
    {
        SceneManager.LoadScene("Tank");
        Time.timeScale = 1;
    }
    public void FlyHack()
    {
        SceneManager.LoadScene("FlyHack");
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
}

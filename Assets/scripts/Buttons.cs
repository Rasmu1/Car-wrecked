using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void CreativeMode()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoad : MonoBehaviour
{
    public void PlanetLoadScene()
    {
        SceneManager.LoadScene("SpaceMainMenu");
    }

    public void BiologyLoadScene()
    {
        SceneManager.LoadScene("BiologyMainMenu");
    }

    public void MainLoadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Anatomy()
    {
        SceneManager.LoadScene("Anatomy");
    }

     public void Planets()
    {
        SceneManager.LoadScene("Planets");
    }

    public void Quit()
    {
        // Quit the application
        Application.Quit();
    }
}

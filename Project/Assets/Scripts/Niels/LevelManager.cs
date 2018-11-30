using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string leveltoload;

    public void LaadLevel(string levelnaam)
    {
        //levelnaam laden
        SceneManager.LoadScene(levelnaam);
    }

    public void levelLaden()
    {
        SceneManager.LoadScene(leveltoload);
        //aart
    }

    public void StopSpel()
    {
        //spel stoppen
        Application.Quit();
    }
}
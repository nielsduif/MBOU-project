using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public bool isPaused;
    public GameObject pauseCanvas;
    public GameObject pauseCanvasKlein;
    public GameObject optionsCanvas;

    void Start()
    {
        Terug();
    }

    // Update is called once per frame
    void Update()
    {//als de esc key wordt ingedrukt komt het canvas pause aan te staan
        if (isPaused)
        {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0;
            PlayerPrefs.SetFloat("sensitivityx", 0f);
            PlayerPrefs.SetFloat("sensitivityy", 0f);
        }
        else
        {
            pauseCanvas.SetActive(false);
            Time.timeScale = 1;
             PlayerPrefs.SetFloat("sensitivityx", 2f);
            PlayerPrefs.SetFloat("sensitivityy", 2f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void Options()
    {
        pauseCanvasKlein.SetActive(false);
        optionsCanvas.SetActive(true);
    }

    public void Terug()
    {
        pauseCanvasKlein.SetActive(true);
        optionsCanvas.SetActive(false);
    }
}

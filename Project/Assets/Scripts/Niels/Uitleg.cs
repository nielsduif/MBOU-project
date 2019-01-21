using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Uitleg : MonoBehaviour
{
    public Text uitleg;
    public int progress;
    public Text buttontext;
    public GameObject canvasuitleg;
    public bool togglemenu;
    public GameObject DashboardSound;
    public GameObject DashboardPanel;

    // Use this for initialization
    void Start()
    {
        GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
        togglemenu = true;
        //progress = 0;
        PlayerPrefs.SetInt("menu", 1);
        uitleg.text = "Welkom in deze game. Dit spel gaat je een basic uitleg geven over het gebruik van OnderwijsOnline.";
        buttontext.text = "Volgende";
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("menu"));
        if (progress == 1)
        {
            uitleg.text = "Je kunt in deze game rondlopen met de W, A, S, D toetsen. W en S zorgen voor het voor en achteruit bewegen en A en D zorgen voor het naar links en rechts bewegen. Je kunt om je heen kijken door met je muis te bewegen. Als er om een interactie wordt gevraagd zal de toets die je hiervoor moet indrukken E zijn, dit staat dan ook nog op het scherm vermeld.";
        }
        if (progress == 2)
        {
            uitleg.text = "Als eerste opdracht, loop naar de computer toe, en start zet het scherm aan door op E te drukken zodra je in de buurt komt.";
            buttontext.text = "Aan de slag";
        }
        if (progress == 3)
        {
            //progress++;
            canvasuitleg.SetActive(false);
            if (togglemenu == true)
            {
                PlayerPrefs.SetInt("menu", 0);
                togglemenu = false;
            }
        }
        if (progress == 4)
        {
            canvasuitleg.SetActive(true);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            uitleg.text = "In dit scherm kan je selecteren welke onderdelen je wilt leren";
            buttontext.text = "Volgende";
        }
    }

    public void Klik()
    {
        progress++;
        //Debug.Log(progress);
    }

    public void KlikDashboard()
    {
        progress++;
        DashboardSound.SetActive(true);
        DashboardPanel.SetActive(false);
    }
}

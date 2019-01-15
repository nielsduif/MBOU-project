using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class SchermScript : MonoBehaviour
{
    public GameObject scherm;
    public GameObject imgDashboard;
    public GameObject imgelearn;
    public GameObject imgpresentie;
    public Text Warning;

    // Use this for initialization
    void Start()
    {
        // imgDashboard.SetActive(false);
        scherm.SetActive(false);
        Warning.text = "";
        //PlayerPrefs.SetInt("menu", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.DeleteAll();
            print("prefs deleted");
        }

        if (PlayerPrefs.GetString("onderwijsscherm") == "dashboard")
        {
            imgDashboard.SetActive(true);
            imgelearn.SetActive(false);
            imgpresentie.SetActive(false);
        }
        if (PlayerPrefs.GetString("onderwijsscherm") == "elearn")
        {
            imgDashboard.SetActive(false);
            imgelearn.SetActive(true);
            imgpresentie.SetActive(false);
        }
        if (PlayerPrefs.GetString("onderwijsscherm") == "presentie")
        {
            imgDashboard.SetActive(false);
            imgelearn.SetActive(false);
            imgpresentie.SetActive(true);
        }

        // if (PlayerPrefs.GetInt("menu") == 0)
        // {
        //     Close();
        // }
    }

    public void Dashboard()
    {
        if (PlayerPrefs.GetString("scherm") == "dashboard")
        {
            Warning.text = "Je bent al in de Dashboard kamer";
        }

        PlayerPrefs.SetString("scherm", "dashboard");
        Close();
    }

    public void Elearning()
    {
        if (PlayerPrefs.GetString("scherm") == "elearning")
        {
            Warning.text = "Deze heb je al geselecteerd";
        }

        PlayerPrefs.SetString("scherm", "elearning");
        Close();
    }

    public void Presentie()
    {
        if (PlayerPrefs.GetString("scherm") == "presentie")
        {
            Warning.text = "Deze heb je al geselecteerd";
        }

        PlayerPrefs.SetString("scherm", "presentie");
        Close();
    }

    public void Close()
    {
        scherm.SetActive(false);
        PlayerPrefs.SetInt("menu", 0);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchermScript : MonoBehaviour
{
	public GameObject scherm;
    public GameObject imgDashboard;
    public Text Warning;

    // Use this for initialization
    void Start()
    {
       // imgDashboard.SetActive(false);
		Warning.text = "";
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.X)){
			PlayerPrefs.DeleteAll();
		}
    }

    public void Dashboard()
    {
        if (PlayerPrefs.GetString("scherm") == "dashboard")
        {
			Warning.text = "Je bent al in de Dashboard kamer";
        }

        PlayerPrefs.SetString("scherm", "dashboard");

    }

    public void Close()
    {
        scherm.SetActive(false);
    }
}

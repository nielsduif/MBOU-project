using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{

    public Transform player;
    public Text UItext;
    public float range;
    public string Message;
    public GameObject SchermCanvas;
    public string scherm;
    //public GameObject UI;


    // Use this for initialization
    void Start()
    {
        UItext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) <= range)
        {
            UItext.text = "" + Message;
            if (Input.GetKeyDown(KeyCode.E))
            {
                DOTHIS();
                UItext.text = "";
            }
        }
        else
        {
            UItext.text = "";
        }
    }
    public void DOTHIS()
    {
        //print("DOTHISCUNT");
        //UI.SetActive(false);
        PlayerPrefs.SetString("onderwijsscherm", scherm);
        PlayerPrefs.SetInt("menu", 1);
        PlayerPrefs.SetInt("sensx", 0);
        PlayerPrefs.SetInt("sensy", 0);
        SchermCanvas.SetActive(true);
    }
}

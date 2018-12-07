using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {
    public Transform player;
    public Text UItext;
    public float range;
    public string Message;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(player.position, transform.position) <= range)
        {
            UItext.text = "" + Message;
            if (Input.GetKeyDown(KeyCode.E))
            {
                DOTHIS();
            }
        }
        else
        {
            UItext.text = "";
        }
	}
    public void DOTHIS()
    {
        print("DOTHISCUNT");
    }
}

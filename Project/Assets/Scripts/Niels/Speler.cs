using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speler : MonoBehaviour
{

    public int snelheid;

    // Use this for initialization
    void Start()
    {
        if (snelheid == 0)
        {
            snelheid = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}

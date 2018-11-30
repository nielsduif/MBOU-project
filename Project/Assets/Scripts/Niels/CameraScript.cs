using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
//publics defineren
    public Transform volgObject;
    
    public float afstandZ;
    public float afstandY;
    public float afstandX;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (null != volgObject)
        {
            Vector3 positie = transform.position;
            positie.y = volgObject.position.y + afstandY;
            positie.z = volgObject.position.z - afstandZ;
            positie.x = volgObject.position.x + afstandX;
            //de camera gaat het object wat wordt aangegeven volgen inclusief de y,z,x hoeken hiervan met een bepaalde afstand erbij

            // if (Input.GetKey(KeyCode.RightArrow))
            // {
            //     transform.RotateAround(Vector3.zero, Vector3.up, 20 * me.deltaTime);
            // }
			// if (Input.GetKey(KeyCode.LeftArrow))
            // {
            //     transform.RotateAround(Vector3.zero, Vector3.up, -20 * Time.deltaTime);
            // }

            transform.position = positie;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation : MonoBehaviour {

    public Transform target;
    public float smoothTime;
    public float speed;

    public float followDistance = 2f;
    public float verticalBuffer = -5f;
    public float horizontalBuffer = 0f;

    private Vector3 velocity = Vector3.zero;

    public Quaternion rotation = Quaternion.identity;

    public float yRotation = 0.0f;

    void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(horizontalBuffer, followDistance, verticalBuffer));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        //this is the code that solves the problem
        transform.eulerAngles = new Vector3(0, target.transform.eulerAngles.y, 0);
        //------------------------------------------------------------------------
    }
}

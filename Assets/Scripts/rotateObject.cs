using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{

    public GameObject objectRotate; // Declare a GameObject variable to store the object to be rotated
    public float rotateSpeed = 50f; // Declare a float variable to store the speed at which the object will rotate
    bool rotateStatus = false; //Declare a boolean variable to store the status of the rotation
    public void RotatedObject()
    {
        // Check if rotateStatus is false
        if (rotateStatus == false)
        {
             // If rotateStatus is false, set it to true
            rotateStatus = true;
        }
        else
        {
            // If rotateStatus is true, set it to false
            rotateStatus = false;
        }
    }

    void Update()
    {
        // if rotateStatus is true, rotate object with speed
        if (rotateStatus == true)
        {
            // Rotate the object around the y-axis by the rotateSpeed multiplied by the time since the last frame
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
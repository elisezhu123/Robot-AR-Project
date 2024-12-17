using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{

    public GameObject objectRotate; // Declare a GameObject variable to store the object to be rotated
    public float rotateSpeed = 50f; // Declare a float variable to store the speed at which the object will rotate
    bool rotateStatus = false; //Declare a boolean variable to store the status of the rotation

    Music audioManager; // Declare a Music variable named "audioManager"

    private void Awake()
    {
        // Get the AudioManager component from the GameObject
         audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Music>(); 
    }

    public void RotatedObject()
    {
        // Check if rotateStatus is false
        if (rotateStatus == false)
        {
            audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
             // If rotateStatus is false, set it to true
            rotateStatus = true;
        }
        else
        {
            audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
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
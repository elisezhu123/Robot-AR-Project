using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public GameObject Object; // Declare a GameObject variable
    // Declare two boolean variables to store zoom in and zoom out states
    private bool _ZoomIn; 
    private bool _ZoomOut;
    public float Scale = 0.1f; // Declare a public float variable named Scale and assigns it a value of 0.1f.

    Music audioManager; // Declare a Music variable named "audioManager"

    private void Awake()
    {
        // Get the AudioManager component from the GameObject
         audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Music>(); 
    }

    void Update()
    {
        // Check if the zoom-in button is pressed
        if (_ZoomIn)
        {
            // Increases the scale of an object by the value of the variable Scale
            Object.transform.localScale += new Vector3(Scale, Scale, Scale);
        }

       // Check if the zoom-out button is pressed
        if (_ZoomOut)
        {
            // Decreases the scale of an object by the value of the variable Scale
            Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
        }
    }

    // This function is called when the zoom-in button is pressed
    public void OnPressZoomIn()
    {
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
        // Set the ZoomIn flag to true
        _ZoomIn = true;
    }

    // This function is called when the user releases the zoom-in button
    public void OnReleaseZoomIn()
    {
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
         // Set the ZoomIn flag to false
        _ZoomIn = false;
    }

    // This function is called when the zoom-out button is pressed
    public void OnPressZoomOut()
    {
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
        // Set the ZoomOut flag to true
        _ZoomOut = true;
    }

    // This function is called when the user releases the zoom-out button
    public void OnReleaseZoomOut()
    {
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
        // Set the ZoomOut flag to false
        _ZoomOut = false;
    }
}
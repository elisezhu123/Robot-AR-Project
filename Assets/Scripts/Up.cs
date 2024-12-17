using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Up: MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false; // Declare a boolean variable to store whether a key is pressed or not
    public GameObject player; // Declare a GameObject variable to store the player object
    public float Force; // Declare a float variable to store the force applied to the player


    Music audioManager;

    private void Awake()
    {
        // Get the AudioManager component from the GameObject
         audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Music>(); 
    }
    void Update()
    {
        // If the button is pressed, move the player to the left
        if (isPressed)
        {
            
            //Move the player in the y-axis by the force multiplied by the time deltaTime
            player.transform.Translate(0, Force * Time.deltaTime, 0);
        }
    }

    // When the button is pressed down, set isPressed to true
    public void OnPointerDown(PointerEventData eventData)
    {
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
        isPressed = true;
    }

    // When the button is released, set isPressed to false
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}

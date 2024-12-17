using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class MenuControl : MonoBehaviour
{
    
    public GameObject triangle; // Reference to the triangle GameObject
    public float delay = 0.5f;  // Delay before transitioning to the next scene

    Music audioManager; // Declare a Music variable named "audioManager"

    private void Awake()
    {
        // Get the AudioManager component from the GameObject
         audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Music>(); 
    }   

    public void StartGame()
    {
        // Log a message to the console
        Debug.Log("Starting Game..."); 
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed

        // Check if the triangle is not null
        if (triangle != null)
        {
            // Activate the triangle GameObject
            triangle.SetActive(true);
        }
        // Start the coroutine to transition to the next scene
        StartCoroutine(LoadSceneAfterDelay());
    }

    // Load a scene after a delay
    private IEnumerator LoadSceneAfterDelay()
    {
        //Pause the execution of the coroutine for a specified amount of time.
        yield return new WaitForSeconds(delay);
        // Transition to the AR scene
        SceneManager.LoadScene(1); 
    }

    public void QuitGame()
    {
        audioManager.PlayButtonClick(audioManager.buttonClick); // Play the audio clip when the button is pressed
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in Unity Editor
    #else
        Application.Quit(); // Quit the application in a built version
    #endif
        Debug.Log("Quitting Game..."); // Log a message to the console
    }
}
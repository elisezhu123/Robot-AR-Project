using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace
using Vuforia; // Vuforia namespace

public class MenuControl : MonoBehaviour
{
    
    public GameObject triangle; // Reference to the triangle GameObject
    public float delay = 0.5f;  // Delay before transitioning to the next scene

    public void StartGame()
    {
        // Log a message to the console
        Debug.Log("Starting Game..."); 

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
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in Unity Editor
    #else
        Application.Quit(); // Quit the application in a built version
    #endif
        Debug.Log("Quitting Game..."); // Log a message to the console
    }
}
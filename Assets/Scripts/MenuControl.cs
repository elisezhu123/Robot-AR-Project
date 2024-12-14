using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuControl: MonoBehaviour
{
    public GameObject triangle; // Reference to the triangle GameObject
    public float delay = 0.5f;  // Delay before transitioning to the next scene

    public void StartGame()
    {
        Debug.Log("Starting Game..."); // Log a message to the console

        // Activate the triangle GameObject
        if (triangle != null)
        {
            triangle.SetActive(true);
        }

        // Start the coroutine to transition to the next scene
        StartCoroutine(LoadSceneAfterDelay());
    }

     private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(1); // Transition to the AR scene
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in the editor
        Application.Quit(); 
        Debug.Log("Quitting Game...");
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
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
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in Unity Editor
#else
        Application.Quit(); // Quit the application in a built version
#endif
        Debug.Log("Quitting Game...");
    }
}
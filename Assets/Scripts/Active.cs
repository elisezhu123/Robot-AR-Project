using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject Active; // Reference to the triangle image

    // Function to show the triangle when Start is clicked
    public void OnStartButtonClick()
    {
        if (Active != null)
        {
            // Set the triangle image to active
            Active.SetActive(true);
        }
    }

    // Function to hide the triangle when Quit is clicked (optional)
    public void OnQuitButtonClick()
    {
        if (Active != null)
        {
            // Hide the triangle image
            Active.SetActive(false);
        }
    }
}
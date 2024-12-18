using UnityEngine;
using UnityEngine.Android;

public class CameraPermissionHandler : MonoBehaviour
{
    void Start()
    {

// Check if the user has authorized permission to use the camera
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // Log a message to the console if the user has not authorized permission
            Debug.Log("Requesting camera permission...");
            // Request the user's permission to use the camera
            Permission.RequestUserPermission(Permission.Camera);
        }
        else
        {
            // Log a message to the console if the user has already authorized permission
            Debug.Log("Camera permission already granted.");
        }
    }

    void Update()
    {
       
// Check if the user has authorized permission to use the camera
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // If the user has not authorized permission, log a warning message
            Debug.LogWarning("Camera permission denied. Camera functionality will not work.");
        }
    }
}
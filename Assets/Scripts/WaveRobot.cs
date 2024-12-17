using UnityEngine;

public class WaveRobot  : MonoBehaviour
{

    public GameObject robot; // Declare a public GameObject variable named "robot"
    private Animator animator; // Declare a private variable of type Animator
    void Start()
    {
        // Check if the robot is not null
        if (robot != null)
        {
            // Get the Animator component from the robot
            animator = robot.GetComponent<Animator>();
        }
    }

    // Public method to trigger animations (connected to Button)
    public void StartWave()
    {
        // Check if the animator is not null
        if (animator != null)
        {
            // Reset IsPlaying to ensure the animation sequence can run
            animator.SetBool("IsPlaying", false); //Set the IsPlaying boolean to false
            animator.SetTrigger("Wave"); //Set the Wave trigger
            animator.SetBool("IsPlaying", true); //Set the IsPlaying boolean to true
        }
    }
}
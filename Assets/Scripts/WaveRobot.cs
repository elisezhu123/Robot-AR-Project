using UnityEngine;

public class WaveRobot  : MonoBehaviour
{
    public GameObject robot; // Reference to the robot GameObject
    private Animator animator;

    void Start()
    {
        if (robot != null)
        {
            animator = robot.GetComponent<Animator>();
        }
    }

    // Public method to trigger animations (connected to Button)
    public void StartWave()
    {
        if (animator != null)
        {
            // Reset IsPlaying to ensure the animation sequence can run
            animator.SetBool("IsPlaying", false);
            animator.SetTrigger("Wave");
            animator.SetBool("IsPlaying", true);
        }
    }
}
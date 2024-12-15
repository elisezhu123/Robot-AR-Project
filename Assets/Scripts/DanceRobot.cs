using UnityEngine;

public class DanceRobot : MonoBehaviour
{
    public GameObject robot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void executeTrigger (string triggerName)
    {
        if (robot != null)
        {
            var animator = robot.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger(triggerName);
            }
        }
    }

    public void StartDance()
    {
        executeTrigger("Dance");
    }
}

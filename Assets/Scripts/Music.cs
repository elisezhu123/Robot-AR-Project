using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource musicSource; // Declare a public AudioSource variable named "musicSource"
    [SerializeField] AudioSource SoundEffects; // Declare a public AudioSource variable named "SoundEffects"
    
    public AudioClip background; // Declare a public AudioClip variable named "backgroundMusic"
    public AudioClip buttonClick; // Declare a public AudioClip variable named "buttonClick"

    private void Start()
    {
        // Play the background music
        musicSource.clip = background;
        musicSource.Play();
    }

    // When the play button is clicked
    public void PlayButtonClick(AudioClip clip)
    {
        SoundEffects.PlayOneShot(clip); // Play the button click sound effect
    }
}

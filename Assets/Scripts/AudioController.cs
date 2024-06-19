using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isPlaying = false;

    public void ToggleAudio()
    {
        if (isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
        else
        {
            audioSource.Play();
            isPlaying = true;
        }
    }
}

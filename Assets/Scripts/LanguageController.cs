using UnityEngine;
using UnityEngine.UI;

public class LanguageController : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    private AudioSource currentAudioSource;

    public Button languageButton;
    public Button playButton;
    //public Button pauseButton;
    public Button stopButton;

    private bool isLanguage1 = true;
    private bool isButtonClickable = true; // Flag to prevent multiple clicks

    void Start()
    {
        currentAudioSource = audioSource1;
        languageButton.onClick.AddListener(ToggleLanguage);
        playButton.onClick.AddListener(PlayAudio);
        //pauseButton.onClick.AddListener(PauseAudio);
        stopButton.onClick.AddListener(StopAudio);
    }

    public void ToggleLanguage()
    {
        if (!isButtonClickable)
            return;

        isButtonClickable = false; // Disable button temporarily

        if (currentAudioSource.isPlaying)
        {
            currentAudioSource.Stop(); // Stop the current audio before changing language
        }
        
        isLanguage1 = !isLanguage1;
        if (isLanguage1)
        {
            currentAudioSource = audioSource1;
            Debug.Log("Language 1 selected");
        }
        else
        {
            currentAudioSource = audioSource2;
            Debug.Log("Language 2 selected");
        }

        // Enable button after a short delay to prevent rapid clicks
        Invoke("EnableButtonClick", 0.5f);
    }

    private void EnableButtonClick()
    {
        isButtonClickable = true;
    }

    public void PlayAudio()
    {
        currentAudioSource.Play();
    }

    public void PauseAudio()
    {

        currentAudioSource.Pause();

    }

    public void StopAudio()
    {
        currentAudioSource.Stop();
    }
}

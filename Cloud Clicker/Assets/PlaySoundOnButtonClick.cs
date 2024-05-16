using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnButtonClick : MonoBehaviour
{
    public Button yourButton;
    public AudioSource audioSource;

    void Start()
    {
        // Butona t�klama olay�n� dinle
        yourButton.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        // Ses kayna��ndaki sesi �al
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}

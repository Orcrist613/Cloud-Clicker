using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnButtonClick : MonoBehaviour
{
    public Button yourButton;
    public AudioSource audioSource;

    void Start()
    {
        // Butona týklama olayýný dinle
        yourButton.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        // Ses kaynaðýndaki sesi çal
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}

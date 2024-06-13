using UnityEngine;

public class AudioController : MonoBehaviour
{
    // AudioSource onde irá reproduzir o sons de clicks
    [SerializeField] AudioSource ButtonClickSound;

    // Toca o som do click
    public void PlayerButtonSound()
    {
        ButtonClickSound.Play();
    }
}
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    [SerializeField]
    private AudioClip scoreHighlight;
    [SerializeField]
    private AudioClip jumpSound;
    [SerializeField]
    private AudioSource audioSource;

    public AudioClip ScoreHighLight => scoreHighlight;
    public AudioClip JumpSound => jumpSound;

    public void PlaySFX(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}

using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    [SerializeField]
    private AudioClip scoreHighlightSound;
    [SerializeField]
    private AudioClip jumpSound;
    [SerializeField]
    private AudioClip gameOverSound;
    [SerializeField]
    private AudioSource audioSource;

    public AudioClip ScoreHighLightSound => scoreHighlightSound;
    public AudioClip JumpSound => jumpSound;
    public AudioClip GameOverSound => gameOverSound;

    public void PlaySFX(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}

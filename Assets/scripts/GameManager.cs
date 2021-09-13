using UnityEngine;

public enum GameState
{
    Ready,
    Start,
    GameOver,
    Win
}

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager Instance { get { if (instance == null) instance = FindObjectOfType<GameManager>(); return instance; } }

    [Header("GameState")]
    [SerializeField]
    private GameState gameState;

    [Header("BGM")]
    [SerializeField]
    private AudioSource bgmSource;

    public GameState GameState
    {
        get => gameState;
        set => gameState = value;
    }
    public void ChangeStateToStartOnClick() => gameState = GameState.Start;

    public void StopBackgroundSound() => bgmSource.Stop();
}

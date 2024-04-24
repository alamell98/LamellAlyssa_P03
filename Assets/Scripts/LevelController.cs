// LevelController.cs
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScoreTextView;
    private int _currentScore;

    // Reference to the player GameObject
    [SerializeField] private GameObject _player;

    // NPC detection range
    [SerializeField] private float _npcDetectionRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckNPCAwareness();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }
    }

    void CheckNPCAwareness()
    {
        // Check if the player is within NPC detection range
        if (Vector3.Distance(transform.position, _player.transform.position) <= _npcDetectionRange)
        {
            // Rotate NPCs to face the player
            transform.LookAt(_player.transform);
        }
    }

    // Method to increase score based on gameplay objectives
    public void IncreaseScore(int scoreIncrease)
    {
        _currentScore += scoreIncrease;
        _currentScoreTextView.text = "Score: " + _currentScore.ToString();
    }

    // Method to return to MainMenu
    public void ReturnToMainMenu()
    {
        // Compare current score with high score
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (_currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", _currentScore);
            Debug.Log("New high score: " + _currentScore);
        }

        // Load MainMenu scene
        SceneManager.LoadScene("MainMenu");
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button _newGameButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _saveButton;
    [SerializeField] private Button _loadButton;
    [SerializeField] private SaveManager _saveManager;

    // configure to determine if data should be reset on new game
    public bool resetDataOnNewGame = true;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // add listeners to the buttons
        _newGameButton.onClick.AddListener(OnNewGameButtonClick);
        _quitButton.onClick.AddListener(QuitGame);
        _saveButton.onClick.AddListener(SaveData);
        _loadButton.onClick.AddListener(LoadData);

        // set the text of the new game button based on the flag
        if (resetDataOnNewGame)
        {
            _newGameButton.GetComponentInChildren<TextMeshProUGUI>().text = "Reset Data";
        }
        else
        {
            _newGameButton.GetComponentInChildren<TextMeshProUGUI>().text = "New Game";
        }
    }

    // button click event for new game button
    public void OnNewGameButtonClick()
    {
        Debug.Log("Starting new game...");

        if (resetDataOnNewGame)
        {
            Debug.Log("Resetting data...");
            _saveManager.SaveData(); // just call savedata directly
            Debug.Log("Data reset successful."); // this message assumes the reset is always successful
        }
        else
        {
            // implement logic specific for starting a new game
            // for example, load a specific scene or initialize the game state
        }
    }


    // button click event for quit button
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        // Quit game
        Application.Quit();
    }

    // button click event for save button
    public void SaveData()
    {
        Debug.Log("Saving data...");
        _saveManager.SaveData();
        Debug.Log("Data saved successfully.");
    }

    // button click event for load button
    public void LoadData()
    {
        Debug.Log("Loading data...");
        _saveManager.LoadData();
        Debug.Log("Data loaded successfully.");
    }
}

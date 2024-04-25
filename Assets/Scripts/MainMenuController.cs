using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button _resetDataButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _saveButton;
    [SerializeField] private Button _loadButton;
    [SerializeField] private Button _newGameButton; // add reference to new game button
    [SerializeField] private SaveManager _saveManager;

    //configure to determine if data should be reset on new game
    public bool resetDataOnNewGame = true;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

     
        _resetDataButton.onClick.AddListener(ResetData);
        _quitButton.onClick.AddListener(QuitGame);
        _saveButton.onClick.AddListener(SaveData);
        _loadButton.onClick.AddListener(LoadData);
        _newGameButton.onClick.AddListener(OnNewGame);
    }

    // button click event for resetdata button
    public void ResetData()
    {
        Debug.Log("Resetting data...");
        // Implement your data reset logic here
        _saveManager.SaveData(); // call save method from savemanager
    }

    // Button click event for Quit button
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        // quit game 
        Application.Quit();
    }

    // Button click event for Save button
    public void SaveData()
    {
        Debug.Log("Saving data...");
        _saveManager.SaveData(); // call save method from savemanager
    }

    // Button click event for Load button
    public void LoadData()
    {
        Debug.Log("Loading data...");
        _saveManager.LoadData(); // call load method from savemanager
    }

    // button click event for new game button
    public void OnNewGame()
    {
        Debug.Log("Starting new game...");

        if (resetDataOnNewGame)
        {
            Debug.Log("Resetting data...");
            _saveManager.SaveData(); // call save method from savemanager
        }
        else
        {
            // implement logic specific for starting a new game
            // for example, use to load a specific scene or initialize the game state
        }
    }
}

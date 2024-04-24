using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button _resetDataButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private SaveManager _saveManager; // Add SaveManager reference

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Add listeners to the buttons
        _resetDataButton.onClick.AddListener(ResetData);
        _quitButton.onClick.AddListener(QuitGame);
    }

    // Button click event for ResetData button
    public void ResetData()
    {
        Debug.Log("Resetting data...");
        // Implement your data reset logic here
        _saveManager.SaveData(); // Call save method from SaveManager
    }

    // Button click event for Quit button
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        // Quit application
        Application.Quit();
    }

    // Method to load saved data
    public void LoadData()
    {
        string savedData = _saveManager.LoadData(); // Call load method from SaveManager
        Debug.Log("Loaded data: " + savedData);
        // Implement your data loading logic here
    }
}

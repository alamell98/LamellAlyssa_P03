using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // method to return to the main menu
    public void ReturnToMainMenu()
    {
        // load mainmenu scene
        SceneManager.LoadScene("MainMenu");
    }

    // method to start a new game
    public void StartNewGame()
    {
        // load your gameplay scene here
        SceneManager.LoadScene("GameplayScene");
    }
}

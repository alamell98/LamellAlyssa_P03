using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Save data method
    public void SaveData()
    {
        // implement your data saving logic here
        Debug.Log("Saving data...");
        PlayerPrefs.SetString("SavedData", "Your saved data here");
        PlayerPrefs.Save();
    }

    // Load data method
    public string LoadData()
    {
        // implement your data loading logic here
        Debug.Log("Loading data...");
        return PlayerPrefs.GetString("SavedData", "");
    }
}

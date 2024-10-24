using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // For scene management
using UnityEngine.UI;              // For UI elements

public class GameManager : MonoBehaviour
{
    public Button restartButton;  // Assign this in the Inspector

    void Start()
    {
        // If the button is assigned in the Inspector, add the listener
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(OnRestartButtonClicked);
        }
        else
        {
            Debug.LogError("Restart Button is not assigned in the Inspector!");
        }
    }

    // This function will be called when the button is clicked
    public void OnRestartButtonClicked()
    {
        Debug.Log("Restart button clicked!");
        //
        // Restart the game by reloading the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

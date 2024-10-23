using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryTextBehavior : MonoBehaviour
{
    public Text victoryText;          // Reference to the UI Text for victory
    //public Transform sphereTransform; // Reference to the sphere's Transform
    //private bool hasWon = false;

    // Define the target position for victory
    private Vector3 targetPosition = new Vector3(90.59912f, -7.159973f, 0.1699982f);

    void Start()
    {
        // Initially hide the victory text
        victoryText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Check if the sphere has reached the target position
        
    }

    // Method to display the victory message
    void DisplayVictoryMessage()
    {
        victoryText.gameObject.SetActive(true);
        victoryText.text = "Victory!";
    }
}



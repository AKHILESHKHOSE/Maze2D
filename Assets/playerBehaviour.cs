using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBehaviour : MonoBehaviour
{
    public Text instructionText;  // Drag your "InstructionText" UI element here
    public Text victoryText;      // Drag your "VictoryText" UI element here

    //private bool hasWon = false;  // Flag to track if victory has been achieved
    private Vector3 targetPosition = new Vector3(90.59912f, -7.159973f, 0.1699982f);

    void Start()
    {
        // Display the instruction message at the start
        //instructionText.text = "You need to keep the sphere at the bottom right!";
        //instructionText.gameObject.SetActive(true);

        // Hide the victory message at the start

        // Hide the instruction message after 5 seconds
    }

    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Jump when the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500f, ForceMode.Impulse);
        }

        // Move right when the right arrow key is pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 500f * Time.deltaTime, ForceMode.VelocityChange);
        }

        // Move left when the left arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * 500f * Time.deltaTime, ForceMode.VelocityChange);
        }

        // Move up when the up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * 500f * Time.deltaTime, ForceMode.VelocityChange);
        }

        // Move down when the down arrow key is pressed
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * 500f * Time.deltaTime, ForceMode.VelocityChange);
        }

        // Check if the sphere's y position is below -6 and update the instruction text to "Victory!"
    }
}

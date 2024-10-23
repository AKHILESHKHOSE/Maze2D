using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionTextBehavior : MonoBehaviour
{
    public Text instructionText;  // Reference to the UI Text for instructions

    void Start()
    {
        if (instructionText == null)
        {
            instructionText = GameObject.Find("InstructionText").GetComponent<Text>(); // Replace "InstructionText" with the actual name of the UI text object
        }

        instructionText.text = "You need to bring the sphere to the bottom.";
        instructionText.gameObject.SetActive(true);

        Invoke("HideInstructionText", 5f);
    }


    // Method to hide the instruction text


    void Update()
    {
        //Debug.Log("Position Y: " + transform.position.y);
        //Debug.Log("Position X: " + transform.position.x);

        if (transform.position.y < -6f && transform.position.x < 110)
        {
            instructionText.text = "Victory!";
        }
    }



}

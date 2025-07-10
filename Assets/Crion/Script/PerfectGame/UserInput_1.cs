using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserInput_1 : MonoBehaviour
{
    public TMP_Text nameText;           // Text that shows the new name
    public Button confirmButton;        // Button to confirm
    public TMP_InputField userInput;    // Input field for user to type

    private void Start()
    {
        confirmButton.onClick.AddListener(UserInput);  // Listen to button click
    }

    public void UserInput()
    {
        string newName = userInput.text;  // Get user input text

        if (!string.IsNullOrEmpty(newName))  // Check if it's not empty
        {
            nameText.text = " " + newName;  // Display it on screen
        }
    }
}

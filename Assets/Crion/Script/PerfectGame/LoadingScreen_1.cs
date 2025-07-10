using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen_1 : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider loadingSlider;           // Slider for progress bar
    public TMP_Text loadingText;           // Text showing % progress
    public TMP_Text nameText;              // Display name after input
    public TMP_InputField userInput;       // Field where user types name
    public Button confirmButton;           // Button to confirm name

    [Header("Panels")]
    public GameObject userPanel;           // Panel for user input
    public GameObject loadingPanel;        // Panel for loading screen

    private float currentValue = 0f;       // Loading progress tracker

    void Start()
    {
        ShowUserInputPanel();                                // Show name input first
        confirmButton.onClick.AddListener(UserInput);        // Listen for button click
    }

    // Show user input panel, hide loading
    public void ShowUserInputPanel()
    {
        userPanel.SetActive(true);
        loadingPanel.SetActive(false);
    }

    // Show loading panel, hide input panel and start coroutine
    public void ShowLoadingPanel()
    {
        userPanel.SetActive(false);
        loadingPanel.SetActive(true);
        StartCoroutine(LoadNextScene());
    }

    // Coroutine to simulate loading progress
    IEnumerator LoadNextScene()
    {
        currentValue = 0f;

        while (currentValue < 1f)
        {
            currentValue += Time.deltaTime / 5f;  // Takes ~5 seconds
            loadingSlider.value = currentValue;
            loadingText.text = "Loading... " + (int)(currentValue * 100f) + "%";
            yield return null;
        }

        // Load the next scene in build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Called when confirm button is clicked
    public void UserInput()
    {
        string newName = userInput.text;

        if (!string.IsNullOrEmpty(newName))
        {
            nameText.text = "WELCOME   " + newName;   // Display name on screen
            ShowLoadingPanel();              // Start loading process
        }
    }
}

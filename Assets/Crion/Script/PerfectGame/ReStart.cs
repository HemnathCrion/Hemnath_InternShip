using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ReStart : MonoBehaviour
{
    public Button reStartButton;
    // Start is called before the first frame update
    void Start()
    {
        reStartButton.onClick.AddListener(RestartGame);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume game time
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

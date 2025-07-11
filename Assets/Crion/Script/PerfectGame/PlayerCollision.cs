using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int score = 0;                         // Coin score
    public TMP_Text scoreText;                    // UI text to show score
    public GameObject gameOverUI;                 // Game Over UI panel

    private void Start()
    {
        UpdateScoreText();
        if (gameOverUI != null)
            gameOverUI.SetActive(false);          // Hide game over at start
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            UpdateScoreText();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Boom"))
        {
            Destroy(gameObject);                  // Eliminate player
            if (gameOverUI != null)
                gameOverUI.SetActive(true);       // Show game over screen
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}


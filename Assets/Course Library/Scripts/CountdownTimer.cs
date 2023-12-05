using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text countdownText;
    public float totalTime = 300.0f; // 5 minutes in seconds
    private float currentTime;
    private bool isGameOver = false;

    private void Start()
    {
        currentTime = totalTime;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime; // Decrement the timer by the time that passed since the last frame.
                UpdateUI();
            }
            else
            {
                // Timer reached 0, trigger game over
                GameOver();
            }
        }
    }

    private void UpdateUI()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        string timeText = string.Format("{0:00}:{1:00}", minutes, seconds);
        countdownText.text = timeText;
    }

    private void GameOver()
    {
        isGameOver = true;

        // Add your game-over logic here, such as loading a game-over scene.
        SceneManager.LoadScene("GameOverScene"); // Replace "GameOverScene" with the name of your game-over scene.

        // You can also handle other game-ending actions, like disabling player input, showing a restart button, etc.
    }
}


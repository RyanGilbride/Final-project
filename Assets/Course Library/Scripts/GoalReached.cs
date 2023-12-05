using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    // Define the range for the triggering line
    private float minX = -369f;
    private float maxX = -367f;
    private float minZ = -244f;
    private float maxZ = -230f;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Check if the player's position is within the specified range
            Vector3 playerPosition = other.transform.position;
            if (playerPosition.x >= minX && playerPosition.x <= maxX &&
                playerPosition.z >= minZ && playerPosition.z <= maxZ)
            {
                // The player crossed the specified line, so end the game
                SceneManager.LoadScene("YourSceneName");
                // Alternatively, you can quit the application using Application.Quit();
                // Application.Quit();
            }
        }
    }
}

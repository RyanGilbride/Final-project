using UnityEngine;

public class Track1Volume : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public float maxDistance = 1000f;  // Maximum distance for full volume
    public float minDistance = 5f;  // Minimum distance for zero volume

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Set the initial volume to full
        audioSource.volume = 1.0f;
    }

    void Update()
    {
        if (player != null)
        {
            // Calculate the distance in the x-z plane between the player and the audio source
            float distanceXZ = Vector2.Distance(new Vector2(transform.position.x, transform.position.z),
                                                new Vector2(player.position.x, player.position.z));

            // Adjust the volume based on the player's distance in the x-z plane
            float volume = Mathf.Clamp01(1 - (distanceXZ - minDistance) / (maxDistance - minDistance));

            // Set the volume of the audio source
            audioSource.volume = volume;
        }
    }
}


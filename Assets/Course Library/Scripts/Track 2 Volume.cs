using UnityEngine;

public class AudioVolumeControlTrack2 : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public float maxDistance = 1000f;  // Maximum distance for full volume
    public float minDistance = 5f;  // Minimum distance for zero volume
    public Vector3 targetPoint = new Vector3(400f, 0f, 420f);  // Target point for zero volume

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
            // Calculate the distance in the x-z plane between the player and Audio Source 2
            float distanceXZ = Vector2.Distance(new Vector2(transform.position.x, transform.position.z),
                                                new Vector2(player.position.x, player.position.z));

            // Calculate the distance between the player and the target point
            float distanceToTarget = Vector3.Distance(player.position, targetPoint);

            // Adjust the volume based on the player's distance in the x-z plane and to the target point
            float volume = Mathf.Clamp01(1 - (distanceXZ - minDistance) / (maxDistance - minDistance));

            // Further decrease volume as the player approaches the target point
            volume *= Mathf.Clamp01(distanceToTarget / maxDistance);

            // Set the volume of the audio source
            audioSource.volume = volume;
        }
    }
}

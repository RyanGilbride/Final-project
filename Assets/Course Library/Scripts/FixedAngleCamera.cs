using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedAngleCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -17);

    // LateUpdate is called after all Update functions have been called
    void LateUpdate()
    {
        // Set the camera's position based on the player's position and rotation
        transform.position = player.transform.position - player.transform.forward * offset.z +
                             player.transform.up * offset.y +
                             player.transform.right * offset.x;

        // Make the camera look from player POV
        transform.LookAt(player.transform.position + player.transform.forward);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera coffinCamera;
    public KeyCode switchKey = KeyCode.F;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // turn
        transform.Rotate(Vector3.up, 10 * horizontalInput);
        // If for multiple camera views
        if (Input.GetKeyDown(switchKey))
        {
            Debug.Log("test");
            mainCamera.enabled = !mainCamera.enabled;
            coffinCamera.enabled = !coffinCamera.enabled;
        }
    }
}

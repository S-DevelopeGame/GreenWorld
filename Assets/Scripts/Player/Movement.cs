using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float JumpImpulse = 7f;
    [SerializeField] float SideSpeed = 2f;

    private Rigidbody rigidBody;
    private TouchDetector touchDetector;
    private bool playerWantsToJump;
    private float horizontalSpeed;
    private float verticalSpeed;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        touchDetector = GetComponent<TouchDetector>();
    }

    void Update()
    {
        // Keyboard events are tested each frame, so we should check them here.
        if (Input.GetKeyDown(KeyCode.Space))
            playerWantsToJump = true;

        horizontalSpeed = Input.GetAxis("Horizontal") * SideSpeed;

        verticalSpeed = Input.GetAxis("Vertical") * SideSpeed;
    }

    void FixedUpdate()
    {
        // Handle jump.
        // NOTE: If instructed to jump, we'll check if we're grounded.
        if (playerWantsToJump && touchDetector.IsTouching())
        {
            rigidBody.AddForce(Vector3.up * JumpImpulse, ForceMode.Impulse);
            Debug.Log("is jumping");
        }
            

        // Set horizontal velocity.
        rigidBody.velocity = new Vector3(horizontalSpeed, rigidBody.velocity.y, verticalSpeed);

        // Reset movement.
        playerWantsToJump = false;
        verticalSpeed = 0f;
        horizontalSpeed = 0f;
    }
}

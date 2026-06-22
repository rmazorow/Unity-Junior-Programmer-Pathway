using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement tuning - editable in Inspector
    public float speed;
    public float turnSpeed;

    // Input System action in Inspector (WASD/Arrow keys)
    public InputAction MoveAction;

    // Current input value (x=left/right, y=forward/backward)
    private Vector2 moveInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the MoveAction to read key press
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read 2D vector from MoveAction to track key press changes
        moveInput = MoveAction.ReadValue<Vector2>();

        // Update your movement to use moveInput
        //     moveInput.y for forward/back -> mapped onto Z
        //     moveInput.x for left/right -> rotate around Y (yaw)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}

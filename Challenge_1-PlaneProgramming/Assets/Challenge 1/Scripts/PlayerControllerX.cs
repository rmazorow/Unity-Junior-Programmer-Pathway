using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
        // Movement tuning - editable in Inspector
    public float speed;
    public float rotationSpeed;

    // Input System action in Inspector (up/down keys)
    public InputAction MoveAction;
    // Current input value
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        // Enable the MoveAction to read key press
        MoveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime * verticalInput);
    }
}

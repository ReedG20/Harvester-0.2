using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    GameObject graphics;

    [SerializeField]
    float speed = 5f;

    private Vector2 movementInput = Vector2.zero;
    private bool dashed = false;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        graphics = transform.GetChild(0).gameObject;
    }

    public void OnMove(InputAction.CallbackContext context) {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnDash (InputAction.CallbackContext context) {
        dashed = context.action.triggered;
    }

    private void Update()
    {
        if (movementInput.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movementInput.x, movementInput.y) * Mathf.Rad2Deg;
            graphics.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            characterController.Move(new Vector3(movementInput.x, 0f, movementInput.y) * speed * Time.deltaTime);
        }

        if (dashed) {
            Debug.Log("Dashing");
        }
    }
}
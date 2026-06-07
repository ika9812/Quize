using UnityEngine;
using UnityEngine.InputSystem;



public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput PlayerInput;

    [SerializeField] float sp;


    Rigidbody rb;

    private void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 move = PlayerInput.actions["Move"].ReadValue<Vector2>();

        Vector3 moveDir =
        transform.right * move.x +
        transform.forward * move.y;

        rb.linearVelocity = new Vector3(moveDir.x * sp, rb.linearVelocity.y, moveDir.z * sp);

        
    }
}

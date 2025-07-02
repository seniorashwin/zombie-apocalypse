using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    private Rigidbody2D _rb;
    private Vector3 _moveInput;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // collect input every frame 
        _moveInput = GameInput.GetMoveInput();
        _moveInput = GameInput.GetMoveInput();  
        _moveInput.Normalize(); // prevents faster diagonal movement 
        
    }

    private void FixedUpdate()
    {
        // apply movement in physics update 
        _rb.linearVelocity = _moveInput * moveSpeed;
    }
}

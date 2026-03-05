using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 0f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) movement.x = -1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) movement.x = 1f;
        movement.y = 0f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) movement.y = -1f;
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) movement.y = 1f;
        movement = movement.normalized;
    }

    void FixedUpdate() 
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}

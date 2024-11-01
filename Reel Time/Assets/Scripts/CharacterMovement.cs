using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Components
    private Rigidbody rb;
    private Animator animator;
    

    // Movement parameters
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    // State variables
    private bool isGrounded;
    private bool isJumping;
    private bool isFacingRight = true;

    // Ground check
    public Transform groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        Animate();
    }

    void FixedUpdate()
    {
        CheckGround();
    }

    void HandleInput()
    {
        // Capture horizontal movement input
        float moveInput = Input.GetAxis("Horizontal");

        // Capture jump input
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

        // Store moveInput for use in Move method
        Move(moveInput);

        // Reset jumping state if grounded
        if (isGrounded)
        {
            isJumping = false;
        }
    }

    void Move(float moveInput)
    {
        // Apply horizontal movement
        rb.velocity = new Vector3(moveInput * moveSpeed, rb.velocity.y, rb.velocity.z);

        // Flip the character based on movement direction
        if (moveInput > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveInput < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void CheckGround()
    {
        // Check if the character is on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
    }
    void Animate()
    {
        // Handle animations based on movement and state
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        animator.SetBool("isGrounded", isGrounded);
        animator.SetBool("isJumping", isJumping);
    }

    void Flip()
    {
        // Flip the character's direction
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
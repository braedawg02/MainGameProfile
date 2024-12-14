using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody rb;
    private Animator animator;
    private Vector3 movement;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component missing from this game object");
        }

        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component missing from this game object");
        }
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        if (rb != null)
        {
            Vector3 velocity = rb.velocity;
            if (velocity.x != 0)
            {
                // Rotate the character to face the direction of the x velocity
                float angle = Mathf.Atan2(0, velocity.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, angle + 90, 0));
            }
        }
        if (movement.x != 0)
        {
            if (animator != null)
            {
                animator.SetBool("isRunning", true);
            }
        }
        else
        {
            if (animator != null)
            {
                animator.SetBool("isRunning", false);
            }
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            if (animator != null)
            {
                animator.SetTrigger("Jump");
            }
            if (rb != null)
            {
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            }
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            rb.velocity = new Vector3(movement.x * moveSpeed, rb.velocity.y, 0); // Ensure no movement on the z-axis
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
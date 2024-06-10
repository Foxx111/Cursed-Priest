using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 3f; // Speed of the player movement
    Rigidbody body;
    float force = 4f;
    //Animator animator;
    bool isJumping = false;
    bool isGrounded = true;
    public float turnSpeed = 180f;

    private void Start()
    {
        //animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Get input from the player
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
        Jump();
    }
    void Move(float h, float v)
    {
        if (h != 0 || v != 0)
        {
            Vector3 movement = new Vector3(h, 0, v).normalized;
            //animator.SetBool("isWalking", true);
            Quaternion targetRotation = Quaternion.LookRotation(-movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
            body.MovePosition(body.position + transform.TransformDirection(-movement) * speed * Time.deltaTime);
        }
        else
        {
            //animator.SetBool("isWalking", false);
        }
        
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //animator.SetBool("isJumping", true);
            isJumping = true;
            body.AddForce(Vector2.up * force, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            //animator.SetBool("isJumping", false);
            isGrounded = true;
            isJumping = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGrounded = false;
            isJumping = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public  bool isGrounded;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the character is grounded
        CheckGround();

        // Move the character
        float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");wswsaa
        Vector2 movement = new Vector2(horizontalInput, 0f /*verticalInput*/ ) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Jump
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void CheckGround()
    {
        
        Collider2D collider = Physics2D.OverlapBox(transform.position, new Vector2(1, 1), 0, LayerMask.GetMask("Terrain"));
        if (collider != null)//<-- We got the Terrain.
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector2(1, 1));
        Gizmos.color = Color.red;
    }
}

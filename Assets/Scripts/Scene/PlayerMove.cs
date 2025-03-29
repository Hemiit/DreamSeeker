using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float jumpForceEx = 10f;

    public bool isGrounded;
    public bool isGroundedEx;

    private Rigidbody2D rb;
    private bool isFull = false;

    public GameObject partMoon;
    public GameObject fullMoon;

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
        // JumpEx
        if (isGroundedEx && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForceEx, ForceMode2D.Impulse);
        }
    }
    private void CheckGround()
    {
        Collider2D collider = Physics2D.OverlapBox(transform.position, new Vector2(1, 1), 0, LayerMask.GetMask("Terrain"));
        if (collider != null)//<-- We got the Terrain.
        {
            isGrounded = true;
            //isGroundedEx = false;
        }
        else
        {
            isGrounded = false;
            //isGroundedEx = false;
        }

        Collider2D colliderEx = Physics2D.OverlapBox(transform.position, new Vector2(1, 1), 0, LayerMask.GetMask("TerrainEx"));
        if (colliderEx != null)//<-- We got the Terrain.
        {
            isGroundedEx = true;
            //isGrounded = false;
        }
        else
        {
            isGroundedEx = false;
            //isGrounded = false;
        }

    }

    public void FullMoon() 
    {
        fullMoon.SetActive(true);
        partMoon.SetActive(false);
    }
    public void PartMoon() 
    {
        fullMoon.SetActive(true);
        partMoon.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "SwiftColli") 
        {
            GameMgr.I.lvl_01.ShowCollider();
            collision.gameObject.SetActive(false);  
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Stressor")
        {
            if (isFull)
            {

            }
            else
            {
                print("Seeker is dead.");
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector2(1, 1));
        Gizmos.color = Color.red;
    }
}

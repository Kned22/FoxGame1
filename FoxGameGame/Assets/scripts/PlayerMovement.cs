using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
    }
    [SerializeField] private float moveInput;
    [SerializeField] private float characterSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(moveInput * characterSpeed, rb.velocity.y);
        rb.velocity = move;
        if (moveInput < 0)
        {
            sprite.flipX = true;
        }
        else if (moveInput > 0)
        {
            sprite.flipX = false;
        }
    }
    public Transform respawnPoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            transform.position = respawnPoint.position;
            rb.velocity = Vector2.zero;
        }
    }
}

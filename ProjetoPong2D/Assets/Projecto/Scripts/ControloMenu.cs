using UnityEngine;
using System.Collections;

public class ControloMenu : MonoBehaviour
{
    public float speed = 10;
    private float move;
    private float move2;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal2");
        move2 = Input.GetAxis("V1");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        rb.velocity = new Vector2(move2 * speed, rb.velocity.x);
    }
}

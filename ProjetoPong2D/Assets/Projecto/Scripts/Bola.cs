using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float initialSpeed = 2f;
    public float maxSpeed = 6f;

    public float difficultyMultiplier = 1.3f;

    private Rigidbody2D rb;
    private Vector2 lastVelocity;

    public AudioSource tickSource;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();

        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector2(initialSpeed * sx, initialSpeed * sy);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 surfaceNormal = collision.contacts[0].normal;
        rb.velocity = Vector2.Reflect(lastVelocity, surfaceNormal);

        if (collision.gameObject.tag == "Limite")
        {
            tickSource.Play();

            if (difficultyMultiplier * initialSpeed < maxSpeed)
            {
                initialSpeed *= difficultyMultiplier;
                rb.velocity *= difficultyMultiplier;
            }
        }
    }
}


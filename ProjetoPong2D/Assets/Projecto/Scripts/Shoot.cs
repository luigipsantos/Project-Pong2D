using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;

    public float speed = 4f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instantiatedProjectile = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;

            Rigidbody2D instantiatedProjectileRb = instantiatedProjectile.GetComponent<Rigidbody2D>();

            instantiatedProjectileRb.AddForce(Vector3.forward * speed);
        }
    }
}
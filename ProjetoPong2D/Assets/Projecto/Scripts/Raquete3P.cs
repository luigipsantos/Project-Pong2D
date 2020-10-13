using UnityEngine;
using System.Collections;

public class Raquete3P : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0) * speed;
    }
}

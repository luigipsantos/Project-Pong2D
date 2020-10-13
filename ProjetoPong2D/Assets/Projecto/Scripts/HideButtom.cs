using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButtom : MonoBehaviour {

    public GameObject Button;

    private void Start()
    {
        Button.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Secret")
        {
            Button.SetActive (true);
        }
    }
}
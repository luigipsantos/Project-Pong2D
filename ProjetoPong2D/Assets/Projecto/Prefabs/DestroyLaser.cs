using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour {

    float lifetime = 2f;

    private void Update()
    {
        Destroy(this.gameObject, lifetime);
    }
}

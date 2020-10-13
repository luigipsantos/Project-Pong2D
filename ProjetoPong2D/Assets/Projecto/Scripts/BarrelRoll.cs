using UnityEngine;
using System.Collections;

public class BarrelRoll : MonoBehaviour
{
    public float rotateAxisX = 25f;
    public float rotateAxisY = 30f;
    public float rotateAxisZ = 45f;

    private void Update()
    {
        transform.Rotate( new Vector3(rotateAxisX, rotateAxisY, rotateAxisZ) * Time.deltaTime);
    }
}

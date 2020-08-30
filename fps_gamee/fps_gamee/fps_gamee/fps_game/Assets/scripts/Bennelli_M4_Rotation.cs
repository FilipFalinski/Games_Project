using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bennelli_M4_Rotation : MonoBehaviour
{
    public float x_Speed = 2f;
    public float y_Speed = 2f;
    public float z_Speed = 2f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x_Speed, y_Speed, z_Speed);
    }
}

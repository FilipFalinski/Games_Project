using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionPulser : MonoBehaviour
{
    public float duration = 5.0F;
    Material myMat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float phi = (Time.time / duration) * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
        float G = amplitude;
        float B = amplitude;

        myMat = GetComponent<Renderer>().material;
        myMat.SetColor("_EmissionPulser", new Color(0f, G, B));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeThrower : MonoBehaviour
{
    public float throwForce = 40f;
    public GameObject granadePrefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            ThrowGranade();
        }
    }

    void ThrowGranade()
    {
      GameObject granade =  Instantiate(granadePrefab, transform.position, transform.rotation);
        Rigidbody rb = granade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }

}

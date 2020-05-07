using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Called when another collider hits the grass.
    // This is part of Unity!
    void OnCollisionEnter(Collision c)
    {
        // Does the other collider have the tag "Player"?
        if (c.gameObject.tag == "Player")
        {
            // Yes it does. Destroy the entire gameObject.
            Destroy(c.gameObject);

         

        }
    }

}
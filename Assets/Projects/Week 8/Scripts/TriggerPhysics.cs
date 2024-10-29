using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPhysics : MonoBehaviour
{
    public Rigidbody targetRb;
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Trigger"))
        {
            targetRb.freezeRotation = false;
            targetRb.constraints = RigidbodyConstraints.None;
        }
    }
}

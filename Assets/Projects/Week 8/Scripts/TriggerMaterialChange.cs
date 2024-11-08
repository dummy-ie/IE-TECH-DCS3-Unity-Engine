using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMaterialChange : MonoBehaviour
{
    [SerializeField] 
    private PhysicMaterial changeMaterial;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("TriggerMaterial"))
        {
            col.material = changeMaterial;
        }
    }
}

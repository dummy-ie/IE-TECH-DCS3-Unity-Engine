using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BillboardRenderer : MonoBehaviour
{
    [Header("LockRotation")]
    [SerializeField]
    private bool LockX;
    [SerializeField]
    private bool LockY;
    [SerializeField]
    private bool LockZ;

    private Vector3 ogRotation;

    private void Awake()
    {
        ogRotation = transform.rotation.eulerAngles;
    }

    private void LateUpdate()
    {
        transform.forward = (transform.position - Camera.main.transform.position).normalized;

        Vector3 rotation = transform.rotation.eulerAngles;

        if (LockX) 
            rotation.x = ogRotation.x;
        if (LockY)
            rotation.y = ogRotation.y;
        if (LockZ)
            rotation.z = ogRotation.z;

        transform.rotation = Quaternion.Euler(rotation);
    }
}

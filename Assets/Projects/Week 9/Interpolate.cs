using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Interpolate : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera;
    [SerializeField] public float speed = 0.1f;

    private CinemachineTrackedDolly trackedDolly;

    void Start()
    {
        trackedDolly = camera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    // Update is called once per frame
    void Update()
    {
        trackedDolly.m_PathPosition += speed * Time.deltaTime;
    }
}

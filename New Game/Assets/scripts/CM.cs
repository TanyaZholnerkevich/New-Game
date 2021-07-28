using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CM : MonoBehaviour
{
    public CinemachineVirtualCamera camera;
    private void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            camera.m_Priority = 20;
        }
        if (Input.GetKey(KeyCode.B))
        {
            camera.m_Priority = 0;
        }
    }
}

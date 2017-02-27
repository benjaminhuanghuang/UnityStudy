using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject tank;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position;
        MoveCamera();
    }
    void LateUpdate()
    {
        MoveCamera();
    }
    void MoveCamera()
    {
        transform.position = tank.transform.position + offset;
    }

}

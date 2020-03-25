using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Ball;
    private Vector3 offset;

    
    void Start()
    {
        offset = transform.position - Ball.transform.position;
    }


    void LateUpdate()
    {
        transform.position = Ball.transform.position + offset;
    }
}

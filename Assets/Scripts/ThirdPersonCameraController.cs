using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour {

    public Transform PlayerTransform;

    private Vector3 camOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    void Start()
    {
        camOffset = transform.position - PlayerTransform.position;
    }


    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + camOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }

}

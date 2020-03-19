using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour {

    public Transform PlayerTransform;
    void Start()
    {
        transform.position = PlayerTransform.position;
        transform.position = transform.position + new Vector3(0, 40, -40);
    }


    void LateUpdate()
    {
        transform.position = PlayerTransform.position;
        transform.position = transform.position + new Vector3(0,40,-40);
    }

}

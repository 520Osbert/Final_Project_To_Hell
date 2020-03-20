using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public Transform PlayerTransform;
	
	void LateUpdate () {
        PlayerTransform = GameObject.Find("Player").GetComponent<Transform>();
        //Debug.Log(PlayerTransform.position);
        if (this.gameObject.transform.position.y >= PlayerTransform.position.y + 100)
        {
            Debug.Log("destroyed");
            Destroy(this.gameObject);
        }
	}
}

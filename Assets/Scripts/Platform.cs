using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    public Layer layer;

    void Start () {
        layer = GameObject.Find("Layer Controller").GetComponent<Layer>();
	}
	
	void Update () {

        if (transform.position.y >= 400)
            transform.Translate(new Vector3(Random.Range(layer.minX, layer.maxX), -400, Random.Range(layer.minZ, layer.maxZ)));
        transform.Translate(0, layer.speed * Time.deltaTime, 0);
	}
}

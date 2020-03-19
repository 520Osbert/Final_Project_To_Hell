using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour {

    private float bottom = -500.0f;
    private float top = 400.0f;
    public float maxX = 100.0f;
    public float minX = -100.0f;
    public float maxZ = 100.0f;
    public float minZ = -100.0f;
    public float speed = 200.0f;
    public float freq = 100.0f;
    public GameObject[] platformsInGame;

	// Use this for initialization
	void Start () {
        Instantiate(platformsInGame[0], new Vector3(0,300, 0), Quaternion.identity);
        for (int i = 1; i < 8; i++)
            Instantiate(platformsInGame[i], new Vector3(Random.Range(minX, maxX), top - 100 - i * freq, Random.Range(minZ, maxZ)), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}

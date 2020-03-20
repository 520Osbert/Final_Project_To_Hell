using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour {

    public float bottom = -500.0f;
    public float top = 400.0f;
    public float maxX = 100.0f;
    public float minX = -100.0f;
    public float maxZ = 300.0f;
    public float minZ = 100.0f;
    public float speed = 200.0f;
    public float freq = 100.0f;
    public GameObject[] platformsInGame;
    public Transform PlayerTransform;

	// Use this for initialization
	void Start () {
        Instantiate(platformsInGame[0], new Vector3(0,300, 0), Quaternion.identity);
        for (int i = 1; i < 8; i++)
            Instantiate(platformsInGame[i], new Vector3(Random.Range(minX, maxX), top - 100 - i * freq, Random.Range(minZ, maxZ)+i*100), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerTransform.position.y <= bottom) {
            bottom = bottom - 75;
            top = top - 75;
            minZ = PlayerTransform.position.z + 100.0f;
            maxZ = PlayerTransform.position.z - 100.0f;
            maxX = PlayerTransform.position.x + 100.0f;
            minX = PlayerTransform.position.x - 100.0f;
            Instantiate(platformsInGame[Random.Range(0,8)], new Vector3(Random.Range(minX, maxX), bottom - 100, Random.Range(minZ, maxZ)), Quaternion.identity);
        }
    }
}

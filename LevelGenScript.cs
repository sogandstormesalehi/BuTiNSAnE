using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenScript : MonoBehaviour {

    public GameObject platformPrefab;
    public float levelWidth;
    public float minY;
    public float maxY;
    private Vector3 spawnPosition = new Vector3();

	void Start () {
        for (int i=0; i <= 10; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        InvokeRepeating("make", 0.1f, 0.2f);

    }
	
    void make() {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
    
}

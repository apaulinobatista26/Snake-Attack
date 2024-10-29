using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemsprefabs;
    private float spawnRangeX = 7;
    private float spawnPosZ = 7; 
    private float delay = 2;
    private float spawnInterval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Clone", delay, spawnInterval);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
  
        private void clone()
       {
         
        int itemindex = Random.Range(0, itemsprefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX ),9.5, spawnPosZ);
        Instantiate(itemsprefabs[itemsprefabs], spawnPos , itemsprefabs[itemindex].transform.rotation);
       }
}
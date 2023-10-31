using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject [] weatherPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnPosY = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            int weatherIndex = Random.Range(0, weatherPrefabs.Length);
            Instantiate(weatherPrefabs[weatherIndex], new Vector3(0, 0, 20), weatherPrefabs[weatherIndex].transform.rotation);
        }
    }
}

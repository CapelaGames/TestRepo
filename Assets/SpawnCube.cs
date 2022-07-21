using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A class contains all our code
public class SpawnCube : MonoBehaviour
{
    //a variable stores data
    public GameObject cubePrefab;
    public Vector3 spawnLocation;

    //Update runs once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) == true)
        {
            Instantiate(cubePrefab, spawnLocation, Quaternion.identity);
        }
    }
}



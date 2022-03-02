using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicGenerateWalker : MonoBehaviour
{
    public GameObject walker;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(12, 0, 0);
        Instantiate(walker, spawnPosition, Quaternion.identity);
    }

    void Update()
    {
        
    }
}

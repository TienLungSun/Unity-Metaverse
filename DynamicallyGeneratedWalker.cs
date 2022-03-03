using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicallyGeneratedWalker : MonoBehaviour
{
    public GameObject walker;
    public Transform target;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(12, 3, 0);
        GameObject w = Instantiate(walker, spawnPosition, Quaternion.identity);
        w.GetComponent<WalkerAgent>().target = target;
        w.GetComponent<WalkerAgent>().MTargetWalkingSpeed = 10.0f;
    }

    void Update()
    {
        
    }
}

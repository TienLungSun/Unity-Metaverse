using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicallyGeneratedMultipleWalkers : MonoBehaviour
{
    public GameObject walker;
    public Transform target;
    List<GameObject> walkersLst = new List<GameObject>();

    void Start()
    {
        float x = -45;  //walkers are generated from x=-45 to 45
        int i = 1;
        float speed = 10.0f;
        while (i <= 5)
        {
            Vector3 spawnPosition = new Vector3(x, 3, 0);
            GameObject w = Instantiate(walker, spawnPosition, Quaternion.identity);
            w.GetComponent<WalkerAgent>().target = target;
            w.GetComponent<WalkerAgent>().MTargetWalkingSpeed = speed;
            walkersLst.Add(w);

            i = i + 1;
            x = x + 5; //next walker is generated with a distance =5
            speed = speed - 3;
            if(speed <= 0) 
            {
                speed = 10.0f;
            }
        }
    }

    void Update()
    {
        
    }
}

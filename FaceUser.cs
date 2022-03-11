using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceUser : MonoBehaviour
{
    Transform mainCamera;

    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera").transform;
    }

    void Update()
    {
        transform.LookAt(mainCamera);
    }
}

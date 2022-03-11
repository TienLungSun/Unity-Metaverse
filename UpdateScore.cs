using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public Transform mainCamera;
    public GameObject walker;

    void Start()
    {
        GetComponent<TextMesh>().text = "0";
    }

    void Update()
    {
        float x = transform.position.x;

        float r= walker.GetComponent < WalkerAgent>().GetCumulativeReward();
        GetComponent<TextMesh>().text = r.ToString();
        transform.LookAt(mainCamera);
    }
}

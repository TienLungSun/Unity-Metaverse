using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public GameObject walker;

    void Start()
    {
        GetComponent<TextMesh>().text = "0";
    }

    void FixedUpdate()
    {
        float r= walker.GetComponent < WalkerAgent>().GetCumulativeReward();
        GetComponent<TextMesh>().text = r.ToString();
    }
}

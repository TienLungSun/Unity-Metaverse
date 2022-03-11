using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Unity.MLAgentsExamples;

public class ReadCSV_GeneratMyWalkers : MonoBehaviour
{
    public GameObject walker;
    public Transform target;
    public Sprite[] spriteArray = new Sprite[5]; //array to store 5 sprites
    List<GameObject> walkersLst = new List<GameObject>();

    void Start()
    {
        StreamReader stream = new StreamReader(Application.dataPath + "/" + "score.csv");
        float x = -48;  //walkers are generated from x=-45 to 45

        string line = stream.ReadLine(); //skip the header line
        while (!stream.EndOfStream)  //read the data part
        {
            x = x + 5; //next walker is generated with a distance =5 
            line = stream.ReadLine();
            string[] subs = line.Split(',');
            int subjectID = int.Parse(subs[0]);
            float speed = float.Parse(subs[1]);

            Vector3 spawnPosition = new Vector3(x, 3, 0);
            GameObject w = Instantiate(walker, spawnPosition, Quaternion.identity);
            w.GetComponent<WalkerAgent>().target = target;
            w.GetComponent<WalkerAgent>().MTargetWalkingSpeed = speed;
            //Image sprite is the 1st child of hips, hips is the first child of w
            GameObject imgSprite = w.transform.GetChild(0).GetChild(0).gameObject;
            imgSprite.GetComponent<SpriteRenderer>().sprite = spriteArray[subjectID-1];
            walkersLst.Add(w);
        }
        stream.Close();
        stream.Dispose();
    }
}

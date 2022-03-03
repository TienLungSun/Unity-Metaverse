using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadCSV : MonoBehaviour
{
    void Start()
    {
        StreamReader stream = new StreamReader(Application.dataPath + "/" + "score.csv");
        string line = stream.ReadLine(); //skip the header line
        while (!stream.EndOfStream)  //read the data part
        {
            line = stream.ReadLine();
            string[] subs = line.Split(',');
            print(subs[1]);
            float speed = float.Parse(subs[1]);
        }
        stream.Close();
        stream.Dispose();
    }

    void Update()
    {
        
    }
}

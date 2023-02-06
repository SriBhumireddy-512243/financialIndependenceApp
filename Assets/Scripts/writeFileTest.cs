using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class writeFileTest : MonoBehaviour
{

    public void writeFile()
    {
        StreamWriter tw = new StreamWriter(Application.persistentDataPath + "/testing.txt");
        tw.Write("Testing");

        tw.Close();
    }

    // Start is called before the first frame update
    void Start()
    {
        StreamWriter tw = new StreamWriter(Application.persistentDataPath + "/test.txt");
        tw.Write("Testing");

        tw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

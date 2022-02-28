using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NewSaveDeta : MonoBehaviour
{
    
    public void NewData()
    {
        StreamWriter posWriter = new StreamWriter(GameManager.PosFileName);
        posWriter.Write("");
        posWriter.Close();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerSave : MonoBehaviour
{

    const char delimiter = '|'; //this would split the string array


    // Start is called before the first frame update
    void Start()
    {
        StreamReader posReader = new StreamReader(GameManager.PosFileName); //open the stream reader
        string newPos = posReader.ReadLine();
        posReader.Close();
        Debug.Log(newPos);

        string[] pos = newPos.Split(new char [] { delimiter });
        transform.position = new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StreamWriter posWriter = new StreamWriter(GameManager.PosFileName);
            posWriter.Write("" +
                 transform.position.x + delimiter +
                 transform.position.y + delimiter +
                 transform.position.z);
            posWriter.Close();

            StreamWriter levelWriter = new StreamWriter(GameManager.LevelFileName);

            if(GameManager.isLevel1 == true)
            {
                levelWriter.Write("isLevel1");
            }
            else if(GameManager.isLevel2 == true)
            {
                levelWriter.Write("isLevel2");
            }
            else if(GameManager.isLevel3 == true)
            {
                levelWriter.Write("isLevel3");
            }

            levelWriter.Close();
        }
    }
}

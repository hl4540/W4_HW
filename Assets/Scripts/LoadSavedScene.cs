using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadSavedScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    public void LoadLevel()
    {
        StreamReader levelReader = new StreamReader(GameManager.LevelFileName);
        string savedLevel = levelReader.ReadLine();
        levelReader.Close();
        Debug.Log(savedLevel);

        if(savedLevel == "isLevel1")
        {
            SceneManager.LoadScene("Level1");
        }else if(savedLevel == "isLevel2")
        {
            SceneManager.LoadScene("Level2");
        }else if(savedLevel == "isLevel3")
        {
            SceneManager.LoadScene("Level3");
        }
    }
}

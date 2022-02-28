using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    public static bool isMenu = true;
    public static bool isLevel1 = false;
    public static bool isLevel2 = false;
    public static bool isLevel3 = false;

    public const string PosFileName = "SavePos.txt";
    public const string LevelFileName = "SaveLevel.txt";




//-----------------------------------------------------
//                     singleton
//-----------------------------------------------------
    private static GameManager instance;

    public static GameManager GetInstance(){
        return instance;
    }

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

//-------------------------------------------------------




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

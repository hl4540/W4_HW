using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

 public void LoadScene(string sceneName)
 {

     if(sceneName == "Menu")
     {
         GameManager.isMenu = true;
         GameManager.isLevel1 = false;
         GameManager.isLevel2 = false;
         GameManager.isLevel3 = false;

         Debug.Log("isMenu:" + GameManager.isMenu);
         Debug.Log("isLevel1:" + GameManager.isLevel1);
                   
     }
     else if(sceneName == "Level1")
     {
         GameManager.isMenu = false;
         GameManager.isLevel1 = true;
         GameManager.isLevel2 = false;
         GameManager.isLevel3 = false;

         Debug.Log("isMenu:" + GameManager.isMenu);
         Debug.Log("isLevel1:" + GameManager.isLevel1);

     }
     else if(sceneName == "Level2")
     {
         GameManager.isMenu = false;
         GameManager.isLevel1 = false;
         GameManager.isLevel2 = true;
         GameManager.isLevel3 = false;

         Debug.Log(GameManager.isLevel2);

     }
     else if(sceneName == "Level3")
     {
         GameManager.isMenu = false;
         GameManager.isLevel1 = false;
         GameManager.isLevel2 = false;
         GameManager.isLevel3 = true;

         Debug.Log(GameManager.isLevel3);

     }

     SceneManager.LoadScene(sceneName);
 }
}

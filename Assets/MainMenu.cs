using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene(GameObject.Find("GameDataObject").GameData.sceneName);
        //Debug.Log(GameObject.Find("GameDataObject"));
    }

    public void continueGame(){
        SceneManager.LoadScene("SampleScene");
        
    }

    public void quitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}

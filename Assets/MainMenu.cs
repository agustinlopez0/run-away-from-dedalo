using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("tutorial");
        //SceneManager.LoadScene(GameObject.Find("GameDataObject").GameData.sceneName);
        //Debug.Log(GameObject.Find("GameDataObject"));
    }

    public void continueGame(){
        SceneManager.LoadScene("tutorial");
        
    }

    public void quitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}

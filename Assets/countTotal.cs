using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countTotal : MonoBehaviour
{
    public GameObject endGame;
    // Update is called once per frame
    void Update()
    {
        GameObject lgComponent = GameObject.Find("LoadGame");
        GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
        if(refScript.gameData.valor==31){
            endGame.SetActive(true);
        }
    }
}

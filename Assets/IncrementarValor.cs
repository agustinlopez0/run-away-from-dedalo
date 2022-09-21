using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementarValor : MonoBehaviour
{
    public void incremento(){
        Debug.Log(GameObject.Find("Save State Button"));
        Debug.Log(GameObject.Find("LoadGame"));
        GameObject lgComponent = GameObject.Find("LoadGame");
        GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
        refScript.gameData.valor++;
    }
}

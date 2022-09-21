using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementarValor : MonoBehaviour
{
    public void incremento(){
        Debug.Log(GameObject.Find("Save State Button"));
        GameDataManager refScript = GetComponent<GameDataManager>();
        refScript.gameData.valor++;
    }
}

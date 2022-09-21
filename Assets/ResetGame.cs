using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public void reset(){
        GameObject newSave = GameObject.Find("GameDataObject");
        GameDataManager refScript = newSave.GetComponent<GameDataManager>();
        refScript.gameData.valor = 0;
        refScript.writeFile();
    }
}

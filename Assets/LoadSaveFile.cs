using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveFile : MonoBehaviour
{
    void Start(){
        GameDataManager refScript = GetComponent<GameDataManager>();
        refScript.readFile();
        Debug.Log("hooolaa");
    }
}

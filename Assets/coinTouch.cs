using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinTouch : MonoBehaviour
{

    private int getIndex(){
        string str = gameObject.transform.parent.name;
        return int.Parse(str.Substring(10, str.Length-11))-1;
    }

    void OnCollisionEnter(Collision collider){
        if(collider.gameObject.tag=="Player"){
            //increases score
            GameObject lgComponent = GameObject.Find("LoadGame");
            GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
            refScript.gameData.valor++;

            Debug.Log("jaj"+getIndex());

            Destroy(gameObject);
        }
    }
}

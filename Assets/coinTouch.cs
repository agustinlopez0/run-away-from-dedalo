using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinTouch : MonoBehaviour
{
    void OnCollisionEnter(Collision collider){
        if(collider.gameObject.tag=="Player"){
            //increases score
            GameObject lgComponent = GameObject.Find("LoadGame");
            GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
            refScript.gameData.valor++;

            Destroy(gameObject);
        }
    }
}

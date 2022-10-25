using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinTouch : MonoBehaviour
{
    public GameObject light;

    private int getIndex(){
        string str = gameObject.transform.parent.name;
        return int.Parse(str.Substring(10, str.Length-11))-1;
    }

    void Update(){
        GameObject lgComponent = GameObject.Find("LoadGame");
        GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();

        if((refScript.gameData.valor&(1<<getIndex()))!=0){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collider){
        if(collider.gameObject.tag=="Player"){
            //increases score
            GameObject lgComponent = GameObject.Find("LoadGame");
            GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
            //refScript.gameData.valor++;
            refScript.gameData.valor|=(1<<getIndex()); //new coin to be added

            Debug.Log(refScript.gameData.valor);


            Destroy(light);
            Destroy(gameObject);
        }
    }
}

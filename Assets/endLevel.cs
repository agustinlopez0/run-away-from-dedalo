using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject lgComponent = GameObject.Find("LoadGame");
        GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
        Debug.Log(refScript.gameData.valor);
        if(refScript.gameData.valor==5){
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.transform.parent.GetComponent<Collider>().enabled=false;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{
    public int maxScore = 5;
    public GameObject ligth;
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
        if(refScript.gameData.valor == maxScore){
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.transform.parent.GetComponent<Collider>().enabled=false;
            ligth.SetActive(true);
        }
    }
}

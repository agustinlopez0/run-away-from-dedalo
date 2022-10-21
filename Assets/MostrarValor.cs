using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostrarValor : MonoBehaviour
{

    public TMP_Text display;

    private int countSetBits(int x){
        int ans=0;
        while(x>0){
            ans+=(x&1);
            x>>=1;
        }
        return ans;
    }



    // Start is called before the first frame update
    void Start()
    {
        display.text = "hola";
    }

    // Update is called once per frame
    void Update()
    {   
        GameObject lgComponent = GameObject.Find("LoadGame");
        GameDataManager refScript = lgComponent.GetComponent<GameDataManager>();
        //Debug.Log("Valor: "+ refScript.gameData.valor);
        display.SetText("Puntos: "+ countSetBits(refScript.gameData.valor));
        //display.text = "Valor: "+ refScript.gameData.valor;
    }
}

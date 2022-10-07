using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostrarValor : MonoBehaviour
{

    public TMP_Text display;
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
        display.SetText("Puntos: "+ refScript.gameData.valor);
        //display.text = "Valor: "+ refScript.gameData.valor;
    }
}

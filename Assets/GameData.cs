using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData/* : MonoBehaviour*/
{
    // Start is called before the first frame update
    public string sceneName;
    public/* static*/ int valor;

    public void setSceneName(string level){
        sceneName = level;
    }

    /*public static void subirValor(){
        valor++;
    }*/

    public GameData(string level="SampleScene"){
        sceneName = level;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearIf : MonoBehaviour
{
    public positionController presionado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(presionado.isActivated == true){
            gameObject.GetComponent<Renderer>().enabled = false;
        }else{
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}

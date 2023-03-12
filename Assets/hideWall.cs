using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideWall : MonoBehaviour
{

    public MeshRenderer pared;


    // Start is called before the first frame update
    void Start()
    {
        // mesh = pared.GetComponent<MeshRendered>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider collider){
        if(collider.gameObject.tag == "Player"){
            pared.enabled = false;
        }
    }
    
    void OnTriggerExit (Collider collider){
        if(collider.gameObject.tag == "Player"){
            pared.enabled = true;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideWall : MonoBehaviour
{

    public MeshRendered pared;


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
        pared.enabled = false;
    }
    
    void OnTriggerExit (Collider collider){
        pared.enabled = true;
    }

}

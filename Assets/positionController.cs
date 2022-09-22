using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionController : MonoBehaviour
{
    public ConstantForce forces;
    public Transform topButton;
    public Transform downButton;
    public bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,topButton.transform.position.y,gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {   
        if(gameObject.transform.position.y < topButton.transform.position.y){
            gameObject.GetComponent <ConstantForce > ().force = new Vector3(0,15,0);
        }else{
            gameObject.GetComponent <ConstantForce > ().force = new Vector3(0,0,0);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,topButton.transform.position.y,gameObject.transform.position.z);
        }
        if(gameObject.transform.position.y < downButton.transform.position.y){
            isActivated = true;
        }else{
            isActivated = false;
        }
    }
    //gameObject.GetComponent <ConstantForce > ().force = new Vector3(0,20,0);
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public GameObject handPoint;
    public GameObject pickedObject = null;
    
    void Update(){
        if(pickedObject!=null){
            if(Input.GetKey("r")){
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("grabObject")){
            Debug.Log("jaja");
            if(Input.GetKey("e") && pickedObject==null){
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;
            }
        }
    }
}

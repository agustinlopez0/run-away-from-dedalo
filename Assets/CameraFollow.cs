using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    
    void FixedUpdate(){
        transform.position = Vector3.Lerp(transform.position, target.position, smoothSpeed);
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     [SerializeField] private Rigidbody _rb;
//     [SerializeField] private float _speed = 5;
//     private Vector3 _input;


//     void Update() {
//         GatherInput();
//         // float xMove = -1.0f* Input.GetAxis("Horizontal"); // d key changes value to 1, a key changes value to -1
//         // float zMove = -1.0f* Input.GetAxis("Vertical"); // w key changes value to 1, s key changes value to -1
//         Look();
//     }

//     void FixedUpdate() {
//         // transform.Translate(_input * Time.deltaTime * 6); // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 
//         Move();
//     }

//     void Look() {
//         if( _input != Vector3.zero ){
//             var relative = (transform.position + _input) - transform.position;
//             var rot = Quaternion.LookRotation(relative,Vector3.up);

//             transform.rotation = Quaternion.LookRotation(_input);
//         }        
//     }

//     void GatherInput() {
//         float xMove = -1.0f * Input.GetAxisRaw("Horizontal");
//         float zMove = -1.0f * Input.GetAxisRaw("Vertical"); 
//         _input = new Vector3(xMove, 0, zMove);
//     }

//     void Move() {
//         _rb.MovePosition(transform.position + transform.forward * _speed * Time.deltaTime);
//     }


// }




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _turnSpeed = 360;
    private Vector3 _input;

    private void Update() {
        GatherInput();
        Look();
    }

    private void FixedUpdate() {
        Move();
    }

    void GatherInput() {
        float xMove = -1.0f * Input.GetAxisRaw("Horizontal");
        float zMove = -1.0f * Input.GetAxisRaw("Vertical"); 
        _input = new Vector3(xMove, 0, zMove);
    }

    private void Look() {
        if (_input == Vector3.zero) return;

        var rot = Quaternion.LookRotation(_input.ToIso(), Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
    }

    private void Move() {
        _rb.MovePosition(transform.position + transform.forward * _input.normalized.magnitude * _speed * Time.deltaTime);
    }
}

public static class Helpers 
{
    private static Matrix4x4 _isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
    public static Vector3 ToIso(this Vector3 input) => _isoMatrix.MultiplyPoint3x4(input);
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0,  y * Time.deltaTime * velocidadMovimiento);
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     [SerializeField] private Rigidbody _rb;
//     [SerializeField] private float _speed = 5;
//     [SerializeField] private float _turnSpeed = 360;
//     private Vector3 _input;

//     private void Update() {
//         GatherInput();
//         Look();
//     }

//     private void FixedUpdate() {
//         Move();
//     }

//     void GatherInput() {
//         float xMove = -1.0f * Input.GetAxisRaw("Horizontal");
//         float zMove = -1.0f * Input.GetAxisRaw("Vertical"); 
//         _input = new Vector3(xMove, 0, zMove);
//     }

//     private void Look() {
//         if (_input == Vector3.zero) return;

//         var rot = Quaternion.LookRotation(_input.ToIso(), Vector3.up);
//         transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
//     }

//     private void Move() {
//         _rb.MovePosition(transform.position + transform.forward * _input.normalized.magnitude * _speed * Time.deltaTime);
//     }
// }

// public static class Helpers 
// {
//     private static Matrix4x4 _isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
//     public static Vector3 ToIso(this Vector3 input) => _isoMatrix.MultiplyPoint3x4(input);
// }



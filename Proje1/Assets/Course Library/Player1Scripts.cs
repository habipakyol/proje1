using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Scripts : MonoBehaviour
{
    private KeyCode MoveForward = KeyCode.W;
    private KeyCode MoveBackward = KeyCode.S;
    private KeyCode TurnLeft = KeyCode.A;
    private KeyCode TurnRight = KeyCode.D;
    private float speed = 12.0f;
    private float turnSpeed = 25.0f;


    void LateUpdate()
    {
        if (Input.GetKey(MoveForward))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(MoveBackward))
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(TurnLeft))
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
        if (Input.GetKey(TurnRight))
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }

}

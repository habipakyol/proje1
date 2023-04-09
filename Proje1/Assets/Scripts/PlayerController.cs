using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    //private float speed = 20.0f;
    //private float turnspeed = 45f;
    //private float hzInput;
    //private float vInput;

    //void Update()
    //{
    //    hzInput = Input.GetAxis("Horizontal");
    //    vInput = Input.GetAxis("Vertical");
    //    transform.Translate(Vector3.forward * Time.deltaTime * speed * vInput);
    //    transform.Rotate(Vector3.up * hzInput, Time.deltaTime * turnspeed);
    //    //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * hzInput);

    //}


    public string inputID;
    private int speed = 15;
    private int turnspeed = 40;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;


    private void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal" + inputID);
       float forwardInput = Input.GetAxis("Vertical" + inputID);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * horizontalInput, Time.deltaTime * turnspeed);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }


    }


}

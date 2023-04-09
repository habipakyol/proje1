using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);
        //get the user's vertical input



        //move the plane forward at a constant rate
        //transform.Translate(Vector3.forward * speed * Time.deltaTime * 20);

        //tilt the plane up/ down based on up / down arrow keys
        //transform.Rotate(Vector3.up * rotationSpeed * verticalInput * Time.deltaTime);


        //transform.Translate(Vector3.up * verticalInput * rotationSpeed * Time.deltaTime);


    }
}

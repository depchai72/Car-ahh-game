using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        if (rb.useGravity == false)
        {
            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Thoat game...");
            Application.Quit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Plane hit: " + collision.gameObject.name);
        rb.useGravity = true; 
    }
    
}

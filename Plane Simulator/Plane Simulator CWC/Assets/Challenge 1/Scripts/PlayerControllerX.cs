using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float forwardSpeed = 10.0f;
    
    private float verticalInput;
    private float verticalRotateSpeed = 70.0f;


    /*
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    */
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // This will move the plane to the forward so plane will not gonna stop
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);

        // Taking inputs to rotate the plane up or down
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right, verticalInput * Time.deltaTime * verticalRotateSpeed);

      

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //take input for left or right
        horizontalInput = Input.GetAxis("Horizontal");

        //take input for forward or backward movement
        forwardInput = Input.GetAxis("Vertical");

        //Move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //rotate while moving
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

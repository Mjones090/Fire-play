using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    public float xRange = 50;
    public float zRange = 50;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

      
    {
        if (transform.position.x <-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        if (transform.position.z < -zRange/2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange/2);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        { if (Input.GetKeyDown(KeyCode.Space))
            {
                // launch a piece of fuel for the fire from the player
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            } }


        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 

        //Move player forward and backwards based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate player left and right based on horizontal input
        transform.Translate(Vector3.right * speed * horizontalInput *Time.deltaTime);

    }
}

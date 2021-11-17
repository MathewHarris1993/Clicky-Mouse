using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //variables
    private Rigidbody targetRb;



    // Start is called before the first frame update
    void Start()
    {
        //assign targetRb
        targetRb = GetComponent<Rigidbody>();

        //add force to move up
        targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);

        //add force to rotate
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        //create random spawn point
        transform.position = new Vector3(Random.Range(-4, 4), -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

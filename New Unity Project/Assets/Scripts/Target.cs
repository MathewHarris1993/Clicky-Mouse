using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //variables
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float torque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;



    // Start is called before the first frame update
    void Start()
    {
        //assign targetRb
        targetRb = GetComponent<Rigidbody>();

        //add force to move up
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);

        //add force to rotate
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //create random spawn point
        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //created the random up force
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);

    }
    //created the random rotation torque
    float RandomTorque()
    {
        return Random.Range(-torque, torque);

    }
    //created the random x location to spawn
    Vector3 RandomSpawnPos()
    {

        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
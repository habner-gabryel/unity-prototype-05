using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 25;
    private float maxTorq = 10;
    private float xRange = 4;
    private float ySpawn = -6;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    Vector3 RandomForce(){
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque(){
        return Random.Range(-maxTorq, maxTorq);
    }

    Vector3 RandomSpawnPos(){
        return new Vector3(Random.Range(-xRange, xRange), ySpawn);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

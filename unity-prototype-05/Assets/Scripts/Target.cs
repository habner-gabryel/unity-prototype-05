using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 18;
    private float maxTorq = 10;
    private float xRange = 4;
    private float ySpawn = -6;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnMouseDown(){
        Destroy(gameObject);
        gameManager.UpdateScore(5);
    }
    private void OnTriggerEnter(Collider other){
        Destroy(gameObject);
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

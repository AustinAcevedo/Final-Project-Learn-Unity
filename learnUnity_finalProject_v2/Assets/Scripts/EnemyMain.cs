using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody objectRb;
    private float zDestroy = -100;

    private GameObject playerTracker;



    public float awayStrength = 50;
    public float upStrength = 5;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        playerTracker = GameObject.Find("Player Tracker");
    }

    // Update is called once per frame
    void Update()
    {

        // move enemies down
        objectRb.AddForce((playerTracker.transform.position - transform.position).normalized * speed);


        //destroy enemies when they reach screen edge z
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }


}

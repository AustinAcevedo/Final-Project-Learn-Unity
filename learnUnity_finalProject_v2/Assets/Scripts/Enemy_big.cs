using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_big : EnemyMain
{
    //INHERITANCE

    private void Start()
    {
        //POLYMORPHISM
        awayStrength = 3000;

    }
    private void OnCollisionEnter(Collision collision)
    {

        //If player hits big ball, bounce off

        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Enemy Big"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromEnemyBig = (collision.gameObject.transform.position - transform.position);

            playerRigidbody.AddForce(awayFromEnemyBig * awayStrength, ForceMode.Impulse);

        }
    }
}
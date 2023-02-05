using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_standard : EnemyMain
{

    //INHERITANCE

    private void Start()
    {
        //POLYMORPHISM
        awayStrength = 100;
    }
    private void OnCollisionEnter(Collision collision)
    {

        //If player hits big ball, bounce off

        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Enemy Standard"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromEnemyStandard = (collision.gameObject.transform.position - transform.position);

            playerRigidbody.AddForce(awayFromEnemyStandard * awayStrength, ForceMode.Impulse);

        }
    }
}

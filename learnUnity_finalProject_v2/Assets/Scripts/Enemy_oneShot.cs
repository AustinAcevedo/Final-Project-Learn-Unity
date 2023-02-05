using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_oneShot : EnemyMain
{
    //INHERITANCE

    private void Start()
    {
        //POLYMORPHISM
        awayStrength = 100;
    }
    private void OnCollisionEnter(Collision collision)
    {


        // If player hits enemy FB player, bounce out and end game

        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Enemy One Shot"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromEnemyOneShot = (collision.gameObject.transform.position - transform.position);

            playerRigidbody.AddForce(awayFromEnemyOneShot * awayStrength, ForceMode.Impulse);
            playerRigidbody.AddForce(transform.up * upStrength, ForceMode.Impulse);

        }




    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTall : MonoBehaviour
{
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Agus")
        {
            playerMovement.Die();
        }
        //Kill the player
    }

    // Update is called once per frame
    void Update()
    {

    }
}
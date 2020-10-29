﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ClickVelocityComponent : MonoBehaviour
{

    // Class Fields Go Here
    //ex: public int health = 5;
    public Rigidbody rigidbody;
    public int force = 5;
    public bool isDead;

    public GameplayManager manager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // rigidbody acting weird if untouched
    }

    void Update()
    {

      if (Input.GetMouseButtonDown(0)  && isDead == false)
        {
            AddVelocity();
            //AddPosition();
        }
    }

    public void Scored()
    {
        manager.AddScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.CompareTag("Obstacle"))
        {
            // set us to dead
            isDead = true;

            manager.ResetGame();

            // transform.position = (transform.position + new Vector);
            // transform.positin += new Vector;

        }
    }

    void AddVelocity()
    {
        rigidbody.velocity = new Vector3(0, force, 0);

    }


}

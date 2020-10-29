using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DieOnCollision : MonoBehaviour
{

    public GameplayManager manager;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.CompareTag("Obstacle"))
        {
            // set us to dead
            isDead = true;

            manager.ResetGame();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

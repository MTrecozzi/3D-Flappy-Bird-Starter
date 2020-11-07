using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public float poolPosition = -20;
    // reference to the PillarPool
    public PillarPool pool;

    // Update is called once per frame
    void FixedUpdate()
    {
        // if my position far enough left, pool.AddMe();

        // pool.PoolObject(myGameObject);

        if (transform.position.x <= poolPosition)
        {
            pool.PoolObject(gameObject);
        }

        
    }
}

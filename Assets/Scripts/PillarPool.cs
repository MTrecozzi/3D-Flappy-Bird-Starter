using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarPool : MonoBehaviour
{

    //public reference to a GameObject, named gameObjectToSpawn;
    public GameObject gameObjectToSpawn;

    // A Data Structure to Store Our All Pillars
    public Stack<GameObject> pool = new Stack<GameObject>();

    // A Singleton Reference so that our pillars can access this class without a reference

    public GameObject GetGameObject()
    {

        // if we have a Pillar stored in our Pool, get it from our data structure, enable it and return it

        if (pool.Count > 0)
        {
            // return one from the pool, and then remove it from the pool.

            var newObject = pool.Pop();
            newObject.SetActive(true);

            return newObject;
        }

        else
        {
            // if we don't have a pillar in our pool, Instantiate a New Object, and return that

            // Instantiate A Pillar
            GameObject newPillar = Instantiate(gameObjectToSpawn);
            // Tell that pillar, the that pillar pool that it references, is us

            newPillar.GetComponent<PooledObject>().pool = this;

            return newPillar;
        }

    }

    public float GetFloat()
    {
        return 5;
    }


    public void PoolObject(GameObject obj)
    {
        // add a gameobject to the pool, (to the stack);

        obj.SetActive(false);

        pool.Push(obj);
    }

    private GameObject InstantiateObject()
    {
        // Instantiate a copy of our gameObjectToSpawn, and return it;

        return new GameObject();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarPool : MonoBehaviour
{

    public GameObject objectToSpawnAndManage; // prefab plug in

    public GameObject GetPillar()
    {
        // do we have a pillar in the pool,
        // if we do, return that;
        // otherwise add one to the pool through instationa, and return that;

        return new GameObject();
    }


    public void DestroyPillar(GameObject pillarThatMovedPastScreen)
    {
        // instead of destroying it which hurts performance
        // deactivate, hide it from the player, and add it to the pool for the next person who asks for it
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

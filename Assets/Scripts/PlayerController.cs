using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public DieOnCollision collisionManager;
    public ClickVelocityComponent clickVelocity;

    public GameplayManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Scored()
    {
        manager.AddScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && collisionManager.isDead == false)
        {
            clickVelocity.AddVelocity();
            //AddPosition();
        }
    }
}

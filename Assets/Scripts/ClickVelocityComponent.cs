using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ClickVelocityComponent : MonoBehaviour
{

    // Class Fields Go Here
    //ex: public int health = 5;
    public Rigidbody rigidbody;
    public int force = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // rigidbody acting weird if untouched
    }
   

    public void AddVelocity()
    {
        rigidbody.velocity = new Vector3(0, force, 0);

    }


}

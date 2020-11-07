using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseComponent : MonoBehaviour
{
    public Rigidbody rigidbody;
    private bool paused = true;
    public GameplayManager manager;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (paused = true && Input.GetMouseButtonDown(0))
        {
            UnPause();
        }
    }

    public void UnPause()
    {
        rigidbody.isKinematic = false;
        manager.paused = false;
        paused = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public float speed = 10.0f;
    private Rigidbody2D rb;
   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            var vel = rb.velocity;
            vel.x = -speed;
            rb.velocity = vel;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var vel = rb.velocity;
            vel.x = speed;
            rb.velocity = vel;
        }
        else if (!Input.anyKey)
        {
            var vel = rb.velocity;
            vel.x = 0.0f;
            rb.velocity = vel;

        }
        
    }
    
}

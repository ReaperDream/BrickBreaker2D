using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour {

    Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    private Vector2 InitialLocation;
	// Use this for initialization
	void Start () {
        InitialLocation = transform.position;
        rb = GetComponent<Rigidbody2D>();
        
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {
            BallReset();
            rb.AddForce(new Vector2(ballForce, ballForce));
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Reiniciar"))
        {
            transform.position = InitialLocation;
            BallReset();
        }
    }
    void BallReset()
    {
        transform.SetParent(null);
        rb.isKinematic = false;
        gameStarted = true;
    }
    
}

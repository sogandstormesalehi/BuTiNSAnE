using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    float movement = 0f;
    Rigidbody2D rb;
    public float moveSpeed;
	void Start () {
        rb = GetComponent<Rigidbody2D>();	
        for (int i = 0; i < 3600;) {
            Invoke("AddSpeed", i + 30);
            i += 60;
        }
	}

    void AddSpeed() {
        moveSpeed += 3;
    }
	
	void Update () {
        movement = Input.GetAxis("Horizontal") * moveSpeed;
	}

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}

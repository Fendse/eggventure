using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragonMovement : MonoBehaviour
{
    public State state = State.EGG;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Math.Abs(Input.GetAxis("Horizontal")) > 0.0f) {
            Vector2 vOld = rb.velocity;
            Vector2 vNew = Vector2.MoveTowards(vOld, vOld + new Vector2(2.0f, 0.0f), 0.5f * Math.Sign(Input.GetAxis("Horizontal")));
            rb.velocity = vNew;
        }
    }
}

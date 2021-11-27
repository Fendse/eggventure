using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragonMovement : MonoBehaviour
{
    public State state = State.EGG;

    public float stickiness;

    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Math.Abs(Input.GetAxis("Horizontal")) > 0.0f) {
            Vector2 vOld = rigidBody.velocity;
            Vector2 vNew = Vector2.MoveTowards(vOld, vOld + new Vector2(2.0f, 0.0f), 0.5f * Math.Sign(Input.GetAxis("Horizontal")));
            rigidBody.velocity = vNew;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Collider2D other = collision.otherCollider;
        Vector2 stickTo = other.ClosestPoint(gameObject.transform.position);

        Vector2 stickyPosition = Vector2.MoveTowards(transform.position, stickTo, stickiness);

        transform.position = stickyPosition;
    }
}

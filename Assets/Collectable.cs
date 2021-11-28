using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable2D : MonoBehaviour
{
    public abstract void OnCollected(GameObject collector);
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collector"))
        {
            Debug.Log("Collecte by trigger");
            OnCollected(other.gameObject);
        }
        else
        {
            Debug.Log("Triggered by non-collector");
        }
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Collector"))
        {
            Debug.Log("Collected by collision");
            OnCollected(c.gameObject);
        }
        else
        {
            Debug.Log("Collided with non-collector");
        }
    }
}

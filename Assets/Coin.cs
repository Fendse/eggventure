using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable2D
{
    public override void OnCollected(GameObject _collector)
    {
        GameObject.Destroy(gameObject);
    }
}

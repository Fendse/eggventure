using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable2D
{
    public int value;

    public override void OnCollected(GameObject collector)
    {
        ScoreKeeper scoreKeeper = collector.GetComponentInChildren<ScoreKeeper>();
        if (scoreKeeper == null)
        {
            Debug.Log("No score keeper???");
        }
        else
        {
            scoreKeeper.Score += value;
        }
        GameObject.Destroy(gameObject);
    }
}

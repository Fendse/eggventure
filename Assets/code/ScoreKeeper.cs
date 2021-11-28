using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreDisplay;
    
    public static int _score = 0;
    public int Score {
        get {
            return _score;
        }

        set {
            _score = value;
            Debug.Log($"Score set to ${value}");
            if (scoreDisplay != null)
            {
                scoreDisplay.text = $"Heat: ${value}";
            }
        }
    }
}
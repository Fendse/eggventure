using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreDisplay;
    
    private int _score;
    public int Score {
        get {
            return _score;
        }

        set {
            _score = value;
            scoreDisplay.text = $"Heat: ${value}";
        }
    }
}
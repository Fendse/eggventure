using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : Collectable2D
{
    public string sceneName;

    public override void OnCollected(GameObject _collector) {
        SceneManager.LoadScene(sceneName);
    }
}

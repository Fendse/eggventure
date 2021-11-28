using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour {
    public int sceneID;	
    
    public void Update(){
        if (Input.GetButtonDown("Submit"))
        {
            Debug.Log ("You have clicked the button!");
            SceneManager.LoadScene(sceneID); 
	
        }
    }

}

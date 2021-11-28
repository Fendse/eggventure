using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    private float Timer = 1;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update() {
        
        Timer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
        if (Timer > (60))
        {
            SceneManager.LoadScene("good");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
    }
    
    
    
 

    

}


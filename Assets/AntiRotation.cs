using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Transform transform = gameObject.transform;
        Transform parent = transform.parent;
        transform.parent = null;
        Vector3 oldOrientation = transform.eulerAngles;
        Vector3 newOrientation = new Vector3(oldOrientation.x, oldOrientation.y, 0.0f);
        transform.eulerAngles = newOrientation;
        transform.parent = parent;
    }
}

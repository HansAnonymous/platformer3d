using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAfterFallR : MonoBehaviour
{
    Vector3 startposition;
    public float minimumY = -20;
    // Start is called before the first frame update
    void Start()
    {
        startposition = this.transform.position;
        Debug.Log("Hello World" + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minimumY)
        {
            transform.position = startposition;
        }
        
    }
}

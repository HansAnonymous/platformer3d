using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAfterFall : MonoBehaviour
{

    Vector3 startPosition;
    public float minimumY = -20;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;

        Debug.Log("Hello World!" + this.transform.position.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < minimumY)
        {
            transform.position = startPosition;
        }
    }
}

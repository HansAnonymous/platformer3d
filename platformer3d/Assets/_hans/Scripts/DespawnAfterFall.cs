﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnAfterFall : MonoBehaviour
{

    public float minimumY = -20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < minimumY)
        {
            Destroy(gameObject);
        }
    }
}

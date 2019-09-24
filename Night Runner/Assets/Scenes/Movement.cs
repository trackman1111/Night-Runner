﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-.1f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(.1f, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, .1f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -.1f));
        }

    }
}

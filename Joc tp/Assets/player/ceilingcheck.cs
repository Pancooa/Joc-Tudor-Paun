﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceilingcheck : MonoBehaviour
{
    public bool isallowedtouncrouch;
    // Start is called before the first frame update
    void Start()
    {
        isallowedtouncrouch = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isallowedtouncrouch = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isallowedtouncrouch = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INVENTAR : MonoBehaviour
{
    public bool full;
    public SpriteRenderer cheie;
    private void Start()
    {
        cheie.enabled = false;
    }
    private void Update()
    {
        if (full == true)
        {
            cheie.enabled = true;
        }
        if (full == false)
        {
            cheie.enabled = false;
        }
    }



} 
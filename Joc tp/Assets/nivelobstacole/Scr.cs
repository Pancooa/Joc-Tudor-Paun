using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr : MonoBehaviour
{
    public bool PlayerEaCheie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.layer == 11)
        {
            PlayerEaCheie = true;

            Destroy(gameObject);


        }
    }

}
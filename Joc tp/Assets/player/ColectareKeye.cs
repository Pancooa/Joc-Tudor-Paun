using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectareKeye : MonoBehaviour
{

    public bool playerEAcheie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            playerEAcheie = true;

            

            DestroyObject(gameObject);
        }


        void Start()
        {

        }


        void Update()
        {

        }
    }
}
    
    
   
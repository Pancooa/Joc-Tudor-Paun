using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scara : MonoBehaviour
{
    public bool conexiune;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer==11)
        {
            conexiune = false;

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.layer==11)
        {
            conexiune = true;

        }
         
        
    }

    

        
    

    void Start()

    { }


    void Update()
    {
        
    }
}

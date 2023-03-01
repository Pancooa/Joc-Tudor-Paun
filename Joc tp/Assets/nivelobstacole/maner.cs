using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maner : MonoBehaviour
{
    public bool arcisoff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E) == true & collision.gameObject.layer==11)
        {
            arcisoff = true;
        }
    
    }
   
}

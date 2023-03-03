using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maner : MonoBehaviour
{
    public bool arcisoff;
    public Animator arc;
    public Animator manerul;
    public bool maneroff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manerul.SetBool("isoff", arcisoff);
        arc.SetBool("isoff", arcisoff);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E) == true & collision.gameObject.layer==11)
        {
            manerul.SetBool("isoff", true);
            arc.SetBool("isoff", true);
            arcisoff = true;
            maneroff = true;
        }
    
    }
   
}

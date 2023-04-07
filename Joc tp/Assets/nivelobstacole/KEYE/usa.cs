using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usa : MonoBehaviour
{
    public Collider2D hitbxusa;
    public INVENTAR inventar;
    public bool isinrange;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isinrange == true & inventar.full == true & Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("deschis", true);
            hitbxusa.enabled = false;
            inventar.full = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            isinrange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            isinrange = false ;
        }
    }
}

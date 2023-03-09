using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urcaPeScara : MonoBehaviour
{
    public scara urcascara;
    public Rigidbody2D corp;
    public float miscare;
    public bool apasE;
    public Animator animator;
    void Start()
    {
       
    }

    void Update()
    {
        animator.SetBool("estescara", urcascara.conexiune);
        if (Input.GetKeyUp(KeyCode.W) == true & urcascara.conexiune==true)
        {
            apasE = true;
        }

        if (apasE==true & urcascara.conexiune==true)

        {
            corp.velocity = new Vector2(corp.velocity.x,0.9f);

        }


        if (Input.GetKey(KeyCode.W ) & urcascara.conexiune==true)
        {
            apasE = false;
            corp.velocity = new Vector2(0, miscare);

        }

        if (Input.GetKey(KeyCode.S) & urcascara.conexiune == true)
        
            corp.velocity = new Vector2(0, -miscare);
        }

}

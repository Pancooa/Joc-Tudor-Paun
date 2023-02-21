using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urcaPeScara : MonoBehaviour
{
    public scara urcascara;
    public Rigidbody2D corp;
    public float miscare;
    public bool test;
    public bool apasE;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) == true)
        {
            apasE = true;
        }

        if (apasE==true & urcascara.conexiune==true)

        {
            corp.velocity = new Vector2(0,0);
            test = true;

        }


        if (Input.GetKey(KeyCode.E ) & urcascara.conexiune==true)
        {
            apasE = false;
            corp.velocity = new Vector2(0, miscare);

        }

        if (Input.GetKey(KeyCode.R) & urcascara.conexiune == true)
        
            corp.velocity = new Vector2(0, -miscare);
        }

}

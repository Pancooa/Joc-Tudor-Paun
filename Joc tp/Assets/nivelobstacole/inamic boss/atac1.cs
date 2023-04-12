using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atac1 : MonoBehaviour
{
    public Transform bosss;
    public boss boss;
    public Quaternion rotatie;
    public Quaternion rotatieneg;
    public Quaternion rotdef;
    public float rotatietimp;
    public float atacpredicttimer;
    public float atacpredictlimit;
    public float atacstaytimer;
    public float atacstaylimit;
    public bool creere;
    public bool atacare;
    public bool atacinit;
    public Collider2D collider;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        collider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (atacinit == true)
        {
            atacpredicttimer += 1 * Time.deltaTime;
            creere = true;
            if (atacpredicttimer > atacpredictlimit)
            {
                atacare = true;
                atacinit = false;
                boss.instatac1 = false; 
                atacpredicttimer = 0;
            }
        }
        animator.SetBool("atacare", atacare);
        animator.SetBool("ataccreere", creere);
        if (atacare == true)
        {
            collider.enabled = true;
            atacstaytimer += 1 * Time.deltaTime;
            
            if (bosss.localScale.x < 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, rotatieneg, rotatietimp * Time.deltaTime);
            }
            if(bosss.localScale.x>0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, rotatie, rotatietimp * Time.deltaTime);
            }
            
            
        }
        if (atacare == false)
        {

            collider.enabled = false;
            atacstaytimer = 0;
            transform.rotation = rotdef;
            creere = false;
            
        }
        if (atacstaytimer > atacstaylimit)
        {
            atacare = false;
            boss.instatac1 = false;
            boss.movetimerstop = false;
        }
    }
}

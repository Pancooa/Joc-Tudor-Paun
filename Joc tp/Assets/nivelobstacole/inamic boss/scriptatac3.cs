using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptatac3 : MonoBehaviour
{
    public Animator animator;
    public bool atacstrt;
    public bool atacstop;
    public Transform atacp1;
    public Transform atacp2;
    public Transform atacp3;
    public Transform atacp4;
    public GameObject proicetil;
    public float timerrand;
    public float timerrandall;
    public float timerrandlimit;
    public float atacspeed;
    public float atacare;
    public bool allowtofire;
    public float nrprev;
    public bool atac3preda;
    public float atacpred;
    public float atacpredtimer;
    public boss boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("atac3strt",atac3preda);
        if (atac3preda == true)
        {
            atacpred += 1 * Time.deltaTime;
        }
        atacare = atacspeed;
        if (atacpred > atacpredtimer)
        {
            atacstrt = true;
        }
        if (atacstrt == true )
        {
            timerrandall += atacare;
        }
        if (timerrand > timerrandlimit)
        {
            timerrand = 0;
            timerrandall = 0;
            atacstrt = false;
            atacpred = 0;
            atac3preda = false;
            boss.instatac3 = false;
            boss.movetimerstop = false;
        }
        if (allowtofire == false & timerrand != nrprev)
        {
            nrprev = timerrand;
            allowtofire = true;
        }
        timerrand = timerrandall - timerrandall % 1;
        if (timerrand % 2 == 0&timerrand!=0 &atacstrt==true & allowtofire == true)
        {
            Instantiate(proicetil, atacp1.position, atacp1.rotation);
            timerrandall += atacare;
            allowtofire = false;
        }
        else
        {
            if (timerrand % 3 == 0 & timerrand != 0 & atacstrt == true&allowtofire==true)
            {
                Instantiate(proicetil, atacp2.position, atacp2.rotation);
                timerrandall += atacare;
                allowtofire = false;
            }
            else
            {
                if (timerrand % 2.5 == 0 & timerrand != 0 & atacstrt == true & allowtofire == true)
                {
                    Instantiate(proicetil, atacp3.position, atacp3.rotation);
                    timerrandall += atacare;
                    allowtofire = false;
                }
                else
                {
                    if (timerrand % 2.5f == 0 & timerrand != 0 & atacstrt == true & allowtofire == true)
                    {
                        Instantiate(proicetil, atacp4.position, atacp4.rotation);
                        timerrandall += atacare;
                        allowtofire = false;
                    }
                    else
                    {
                        if (atacstrt == true & allowtofire == true )
                        {
                            Instantiate(proicetil, atacp4.position, atacp4.rotation);
                            timerrandall +=atacare;
                            allowtofire = false;
                        }
                    }
                }
            }
        }


    }
}

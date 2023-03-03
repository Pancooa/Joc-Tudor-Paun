using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aruncator_sageti : MonoBehaviour
{
    public GameObject sageata;
    public Transform arc;
    public Vector3 locatie;
    public float timer;
    public float timetoshoot;
    public maner maner;
    public Animator arcul;
    public float timerarcdisc;
    public float timerarcdisctohit;
    public float timersec;
    public bool timercontinuarenr;
    float timetohitsec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maner.arcisoff == false & timerarcdisc>timerarcdisctohit )
        {
            timercontinuarenr = true;
            maner.arcisoff = true;
            timer = 0;

        }
        if (timercontinuarenr == true & maner.maneroff == false & maner.maneroff==false)
        {
            timersec += 1 * Time.deltaTime;
        }
        if (timersec > 0.05f)
        {
            maner.arcisoff = false;
            timerarcdisc = 0;
            timersec = 0;
            timercontinuarenr = false;
        }
        if(maner.maneroff == false)
        {
            timer = timer + 1 * Time.deltaTime;
            timerarcdisc += 1 * Time.deltaTime;
        }
        timerarcdisctohit = timetoshoot * 10;
        arcul.speed = 1 / timetoshoot;
        locatie = arc.position;
        if (timer > timetoshoot & maner.arcisoff==false)
        {
            Instantiate(sageata,arc.position,arc.rotation);
            timer = 0;
        }
    }
}

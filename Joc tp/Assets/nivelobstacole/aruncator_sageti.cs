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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        locatie = arc.position;
        timer = timer + 0.01f;
        if (timer > timetoshoot & maner.arcisoff==false)
        {
            Instantiate(sageata,arc.position,arc.rotation);
            timer = 0;
        }
    }
}

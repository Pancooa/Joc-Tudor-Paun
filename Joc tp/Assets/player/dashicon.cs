using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashicon : MonoBehaviour
{
    public movement movement;
    public Transform transform;
    public float icony;
    public float iconx;
    public float mcony;
    public float mconx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iconx = movement.timerdash / movement.cooldowndash;
        icony = movement.timerdash / movement.cooldowndash;
        if (movement.dshnotcooldown == false)
        {
            transform.localScale = new Vector3(iconx - 0.01f, icony - 0.01f, 1);
            mconx = 1;
            mcony = 1;
        }
        if (movement.isindash == true)
        {
            mconx -= movement.dashtime / 10f * Time.deltaTime;
            mcony -= movement.dashtime / 10f * Time.deltaTime;
            transform.localScale = new Vector3(Mathf.Abs(mconx), Mathf.Abs(mcony), 1);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashicon : MonoBehaviour
{
    public movement movement;
    public Transform transform;
    public float icony;
    public float iconx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iconx = movement.timerdash / movement.cooldowndash;
        icony = movement.timerdash / movement.cooldowndash;
        transform.localScale = new Vector3(iconx-0.01f, icony-0.01f, 1);
    }
}

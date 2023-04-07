using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdmgscript : MonoBehaviour
{
    public atacplyr atacplyr;
    public float hp;
    public float maxhp;
    public float currenthp;
    public bool invincib;
    public float invtimer;
    public float invtimerlimit;
    public bool reset;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxhp;
        currenthp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < currenthp)
        {
            invtimer += 1 * Time.deltaTime;
            invincib = true;
        }
        if (invtimer > invtimerlimit)
        {
            invincib = false;
            invtimer = 0;
            currenthp = hp;
        }
        if (reset == true)
        {
            hp = maxhp;
            currenthp = maxhp;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 16 & invincib == false)
        {
            hp -= atacplyr.dmg;
        }
    }
}

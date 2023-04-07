using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacplyr : MonoBehaviour
{
    public playeraudio audio;
    public Animator animator;
    public bool isattacking;
    public Collider2D hitbx;
    public float dmg;
    // Start is called before the first frame update
    void Start()
    {
        hitbx.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isattacking == true)
        {
            audio.playeratac.enabled = true;
        }
        else
        {
            audio.playeratac.enabled = false;
        }
        animator.SetBool("isatac", isattacking);
        hitbx.enabled = isattacking;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float hpmax;
    public float hp;
    public float hpcurent;
    public bool invincib;
    public float invincibtimer;
    public float invincibtimerlimit;
    public bool alive;
    public Text deathtext;
    public movement movescript;
    public Animator animator;
    public Rigidbody2D corpplayer;
    public float velocityx;
    public Collider2D colo;
    public Vector2 checkpoint;
    public Transform player;
    public maner maner;
    public SpriteRenderer sprite;
    public float nxthplow;
    public float timerdmgeffect;
    public Color dmgcolor;
    public Color defcolor;
    // Start is called before the first frame update
    void Start()
    {
        hpcurent = hpmax; 
        hp = hpmax;
        deathtext.enabled = false;
        alive = true;
        animator.SetBool("isalive", true);

    }

    // Update is called once per frame
    void Update()
    {
        if (timerdmgeffect > 0.5f)
        {
            nxthplow -= 1;
            timerdmgeffect = 0;
            sprite.color = defcolor;
        }
        if (hp == nxthplow)
        {
            timerdmgeffect += 1 * Time.deltaTime;
            sprite.color = dmgcolor;
        
        }

        if (hp < 1)
        {
            alive = false;
        }
        velocityx = corpplayer.velocity.x;
        if (alive == false)
        {
            sprite.color = defcolor;
            animator.SetFloat("speed", 0);
            animator.SetBool("isdashing", false);
            animator.SetBool("isalive", false);
            movescript.enabled = false;
            corpplayer.velocity = new Vector2(0, 0);
            deathtext.enabled = true;
            
        }
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            invincib = false;
            hpcurent = hpmax;
            movescript.timerdash = 0;
            movescript.dshnotcooldown = false;
            movescript.isindash = false;
            corpplayer.velocity = new Vector2(0, 0);
            sprite.color = defcolor;
            nxthplow = hpmax-1;
            maner.maneroff = false;
            maner.arcisoff = false;
            hp = hpmax;
            movescript.wanttouncrouch = true;
            movescript.enabled = true;
            animator.SetBool("isalive", true);
            transform.position = new Vector2(checkpoint.x, checkpoint.y);
            alive = true;
            movescript.stopdash = true;
            deathtext.enabled = false;
        }
        if (hp < hpcurent)
        {
            invincib = true;
            invincibtimer += 1 * Time.deltaTime;
        }
        if (invincibtimer > invincibtimerlimit)
        {
            invincib = false;
            invincibtimer = 0;
            hpcurent = hp;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D colo)
    {
      
    }
}

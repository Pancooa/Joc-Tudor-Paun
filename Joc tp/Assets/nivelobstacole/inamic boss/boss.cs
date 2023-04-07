using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public Collider2D corpboss;
    public Collider2D corpbossmort;
    public bossdmgscript helth;
    public bool isalive;
    public float randomnr;
    public float movetimer;
    public float movetimerlimit;
    public bool shouldatack;
    public bool movetimerstop;
    public Transform atac1brat;
    public Animator animator;
    public atac1 atac1;
    public bool instatac1;
    public bool instatac2;
    public scriptatac3 atac3;
    public bool instatac3;
    public bool instatac4;
    public float atc4timr;
    public float atc4timrlmt;
    public float atc4timrhitlmtbx;
    public Collider2D hitbx4;
    public float predatac2;
    public float nrdshatac2;
    public float vitdsh;
    public Collider2D hitbxatac2;
    public Transform destinatie;
    public Transform dshend1;
    public Transform dshend2;
    public detection detector;
    public detectspate detectorspte;
    public Rigidbody2D corp;
    public GameObject player;
    public float speed;
    public float marimecac;
    public float atac2timer;
    public float nrdshfacute;
    public bool fostdshend1;
    public bool fostdshend2;
    // Start is called before the first frame update
    void Start()
    {
        corpbossmort.isTrigger = true;
        isalive = true;
        marimecac = transform.localScale.x;
        destinatie = dshend2;
        hitbxatac2.enabled = false;
        hitbx4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isalive", isalive);
        if (isalive == false)
        {
            corpboss.enabled = false;
            corp.isKinematic = true;
            corpboss.isTrigger = false;
        }
        if (helth.hp < 1)
        {
            isalive = false;
        }
        if (isalive == true)
        {
            if (instatac1 == true)
            {
                movetimerstop = true;
            }
            if (instatac2 == true)
            {
                movetimerstop = true;
            }
            if (instatac3 == true)
            {
                movetimerstop = true;
            }
            if (instatac4 == true)
            {
                movetimerstop = true;
            }
            if (movetimerstop == false)
            {
                movetimer += 1 * Time.deltaTime;
            }
            if (movetimer > movetimerlimit)
            {
                shouldatack = true;
            }
            if (shouldatack == true)
            {
                movetimerstop = true;
                randomnr = Random.Range(1, 5);
                movetimer = 0;
                shouldatack = false;
            }
            if (randomnr == 1)
            {
                instatac1 = true;
                randomnr = 0;
            }
            if (randomnr == 2)
            {
                instatac2 = true;
                randomnr = 0;
            }
            if (randomnr == 3)
            {
                instatac3 = true;
                randomnr = 0;
            }
            if (randomnr == 4)
            {
                instatac4 = true;
                randomnr = 0;
            }
            animator.SetBool("isdashing", instatac2);
            atac1.atacinit = instatac1;

            if (instatac2 == true)
            {
                atac2timer += 1 * Time.deltaTime;
                hitbxatac2.enabled = true;
                if (atac2timer > predatac2)
                {
                    transform.position = Vector2.MoveTowards(transform.position, destinatie.position, vitdsh);

                    if (destinatie == dshend2)
                    {
                        transform.localScale = new Vector3(marimecac, transform.localScale.y, transform.localScale.z);

                    }
                    if (destinatie == dshend1)
                    {
                        transform.localScale = new Vector3(-marimecac, transform.localScale.y, transform.localScale.z);

                    }
                }
            }
            if (nrdshfacute == nrdshatac2)
            {
                instatac2 = false;
                atac2timer = 0;
                nrdshfacute = 0;
                hitbxatac2.enabled = false;
                movetimerstop = false;
            }

            if (detector.playerin == true & movetimerstop == false)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed);

            }
            if (detectorspte.playerinspt == true & movetimerstop == false)
            {
                //atac1brat.localScale = new Vector3(-atac1brat.localScale.x, atac1brat.localScale.y, atac1brat.localScale.z);
                gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
            }

            if (instatac4 == true)
            {
                atc4timr += 1 * Time.deltaTime;
                corp.velocity = new Vector2(0, 5);
            }
            if (atc4timr > atc4timrhitlmtbx)
            {
                corp.velocity = new Vector2(0, 0);
                hitbx4.enabled = true;
            }
            if (atc4timr > atc4timrlmt)
            {
                atc4timr = 0;
                hitbx4.enabled = false;
                instatac4 = false;
                movetimerstop = false;
            }
            animator.SetBool("atac4init", instatac4);
            atac3.atac3preda = instatac3;
        }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 15)
            {
                destinatie = dshend1;
                if (fostdshend2 == true)
                {
                    nrdshfacute += 1;
                    fostdshend1 = true;
                    fostdshend2 = false;
                }
            }
            if (collision.gameObject.layer == 14)
            {
                destinatie = dshend2;
                if (fostdshend1 == true)
                {
                    nrdshfacute += 1;
                    fostdshend2 = true;
                    fostdshend1 = false;
                }
            }
        }
    

}


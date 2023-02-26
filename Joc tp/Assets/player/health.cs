using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public bool alive;
    public Text deathtext;
    public movement movescript;
    public Animator animator;
    public Rigidbody2D corpplayer;
    public float velocityx;
    public Collider2D colo;
    public Vector2 checkpoint;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        deathtext.enabled = false;
        alive = true;
        animator.SetBool("isalive", true);

    }

    // Update is called once per frame
    void Update()
    {
        if (player.localScale.x < 0)
        {
            deathtext.transform.localScale = new Vector3(-0.03504797f, deathtext.transform.localScale.y, deathtext.transform.localScale.z);
        }
        if (player.localScale.x > 0)
        {
            deathtext.transform.localScale = new Vector3(0.03504797f, deathtext.transform.localScale.y, deathtext.transform.localScale.z);
        }


        velocityx = corpplayer.velocity.x;
        if (alive == false)
        {
            animator.SetFloat("speed", 0);
            animator.SetBool("isdashing", false);
            animator.SetBool("isalive", false);
            movescript.enabled = false;
            corpplayer.velocity = new Vector2(0, 0);
            deathtext.enabled = true;
            
        }
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            
            movescript.enabled = true;
            animator.SetBool("isalive", true);
            transform.position = new Vector2(checkpoint.x, checkpoint.y);
            alive = true;
            movescript.stopdash = true;
            deathtext.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D colo)
    {
      
    }
}

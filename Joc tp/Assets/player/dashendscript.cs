using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashendscript : MonoBehaviour
{
    public Transform dashendorigin;
    public Transform player;
    public Vector2 playr;
    public Vector2 dashorig;
    public float testspped;
    public bool ca;

    // Start is called before the first frame update
    void Start()
    {
        ca = true;
    }

    // Update is called once per frame
    void Update()
    {
        playr.x = player.position.x;
        playr.y = player.position.y;
        dashorig.x = dashendorigin.position.x;
        dashorig.y = dashendorigin.position.y;
        if (ca == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, dashorig, testspped * Time.deltaTime);
        }
        if (ca == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, playr, testspped * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 8)
        {
            ca = false;

        }

   

       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            ca = true;
        }
    }
}

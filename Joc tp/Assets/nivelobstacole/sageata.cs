using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sageata : MonoBehaviour
{
    public Rigidbody2D crpsageata;
    public float vitezasageata;
    public bool shouldfly;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldfly == true)
        {
            crpsageata.velocity = transform.right * vitezasageata;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 )
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.layer == 13)
        {
            shouldfly = true;
        }
    }
}

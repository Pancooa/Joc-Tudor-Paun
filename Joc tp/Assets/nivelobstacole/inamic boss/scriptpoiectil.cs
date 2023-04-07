using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptpoiectil : MonoBehaviour
{
    public Transform boss;
    public Rigidbody2D rb;
    public float speed;
    public float speedminus;
    public bool oprire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.localScale.x < 0&oprire==false)
        {
            rb.velocity = new Vector2(speedminus, 0);
        }
        if (boss.localScale.x > 0&oprire==false)
        {
            rb.velocity = new Vector2(speed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 17)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.layer == 18)
        {
            oprire = true;
        }
        if (collision.gameObject.layer != 18)
        {
            oprire = false;
        }
    }
  
}

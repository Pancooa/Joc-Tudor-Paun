using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public bool alive;
    public Collider2D colo;
    public Vector2 checkpoint;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (alive == false)
        {
            transform.position = new Vector2(checkpoint.x, checkpoint.y);
            alive = true;   

        }
    }
    private void OnTriggerEnter2D(Collider2D colo)
    {
      
    }
}

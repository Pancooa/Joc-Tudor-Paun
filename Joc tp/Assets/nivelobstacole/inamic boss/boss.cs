using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public detection detector;
    public detectspate detectorspte;
    public Rigidbody2D corp;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (detector.playerin == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed);
           
        }
        if (detectorspte.playerinspt == true)
        {
 
            gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrare_scara : MonoBehaviour
{
    public Transform player;
    public bool playerin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerin == true & Input.GetKey(KeyCode.W) == true)
        {
            player.position = new Vector3(gameObject.transform.position.x, player.position.y, player.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            playerin = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            playerin = false; ;
        }
    }
}

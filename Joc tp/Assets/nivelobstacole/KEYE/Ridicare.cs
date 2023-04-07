using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ridicare : MonoBehaviour {

    public INVENTAR inventory;



private void start()

{


}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11 &inventory.full==false)
        {
            inventory.full = true;
            Destroy(gameObject);
        }
    }
}

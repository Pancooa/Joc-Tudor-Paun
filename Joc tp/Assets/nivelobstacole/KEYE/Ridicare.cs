using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ridicare : MonoBehaviour {

    public INVENTAR inventory;
    public GameObject itemButton; 



private void start()

{
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<INVENTAR>();

}
    
void onTriggerEnter2d(Collider2D other)
{

    if (other.CompareTag("Player"))
    {
                             
        for ( int i = 0; i < inventory.slots.Length; i++)
        {
            if  (inventory.isFull[i] == false)
            {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
            }
        }
    }

}



    

     

}

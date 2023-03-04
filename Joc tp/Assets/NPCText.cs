using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCText : MonoBehaviour
{

    public bool texttext;
    public Text DialogNpc;
    public Transform pozitie;

   
    void Start()
    {
        DialogNpc.enabled = false;
    }

   
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.V) == true & collision.gameObject.layer == 11 )
        {
            DialogNpc.enabled = true;
            texttext = true;







        }
    }







}



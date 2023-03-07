using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCText : MonoBehaviour
{

    public bool spoken;//variabila asta verifica daca textul a fost vorbit
    public bool isinhitbox;//variabila asta verifica daca playeru este in hitbox
    public float timervorbit;//asta este un timer care iti da voie sa treci la urmatoarea linie de dialog sau sa inchizi dialogu dupa niste timp
    public bool timervorbitadv;//asta e o variabila care este necesara pentru timer
    public float liniecurenta=1;
    public Text DialogNpc1;
    public bool Dialoc1exista;
    public Text DialogNpc2;
    public bool Dialog2exista;
    public Text DialogNpc3;
    public bool Dialog3exista;
    public Text DialogNpc4;
    public bool Dialog4exista;
    public Text DialogNpc5;
    public bool Dialog5exista;
    public Transform pozitie;
    public Image CarcasaDialog;
    public AudioSource bell;
    void Start()
    {
        DialogNpc1.enabled = false;
        DialogNpc2.enabled = false;
        DialogNpc3.enabled = false;
        DialogNpc4.enabled = false;
        DialogNpc5.enabled = false;
        CarcasaDialog.enabled = false;
        bell.enabled = false;
}

   
    void Update()
    {
        if (timervorbitadv == true)
        {
            timervorbit += 1 * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.V) == true&isinhitbox==true)
        {
      
            Nextline();
            liniecurenta += 1;
        }
        if (Input.GetKeyDown(KeyCode.V) == true & spoken == true&timervorbit>0.1f&isinhitbox==true)
        {
           

        }
        if (isinhitbox == false)
        {
            liniecurenta = 0;
            CarcasaDialog.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = false;
            bell.enabled = false;
            
        }

    }
    private void Nextline()
    {
        if (liniecurenta == 0 & Dialoc1exista == true)
        {
            DialogNpc1.enabled = true;
            CarcasaDialog.enabled = true;
            bell.enabled = true;
        }
        if (liniecurenta == 0 & Dialoc1exista == false)
        {
            liniecurenta = 0;
            CarcasaDialog.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = false;
            bell.enabled = false;
        }
        if (liniecurenta == 1&Dialog2exista==true)
        {
            bell.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = true;
            CarcasaDialog.enabled = true;
        }
        if (liniecurenta == 1 & Dialog2exista == false)
        {
            liniecurenta = 0;
            CarcasaDialog.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = false;
            bell.enabled = false;
        }
        if (liniecurenta == 2 & Dialog3exista == true)
        {
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = true;
            CarcasaDialog.enabled = true;
        }
        if (liniecurenta == 2 & Dialog3exista == false)
        {
            liniecurenta = 0;
            CarcasaDialog.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = false;
            bell.enabled = false;
        }
        if (liniecurenta == 3 & Dialog4exista == true)
        {
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = true;
            CarcasaDialog.enabled = true;
        }
        if (liniecurenta == 3 & Dialog4exista == false)
        {
            liniecurenta = 0;
            CarcasaDialog.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = false;
            bell.enabled = false;
        }
        if (liniecurenta == 4 & Dialog5exista == true)
        {
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = true;
            CarcasaDialog.enabled = true;
        }
        if (liniecurenta == 4 & Dialog5exista == false)
        {
            liniecurenta = 0;
            CarcasaDialog.enabled = false;
            DialogNpc1.enabled = false;
            DialogNpc2.enabled = false;
            DialogNpc3.enabled = false;
            DialogNpc4.enabled = false;
            DialogNpc5.enabled = false;
            bell.enabled = false;
        }
        if (liniecurenta == 6)
        {
            DialogNpc5.enabled = false;
            CarcasaDialog.enabled = false;
        }
    }
    //am observat ca ontrigger enter si exit detecteaza mai bine daca este sau nu in hitbox
    //chestiilea astea de jos sunt practic un ontrigger stay cum aveai inainte numa ca merg mai bine
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            isinhitbox = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            isinhitbox = false;
        }
    }
 
   


    }













using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    public Rigidbody2D corp;
   public  Collider2D colidplayer;
    public dashendscript dshscript;
    public Transform corpus;
    public float jumptoken;
    public float jumph;
    public Rigidbody2D picior;
    public picior script;
    public float movespeed;
    private float horiz;
    public bool isdashing;
    public bool stopdashing;
    public Transform dashend;
    public Vector3 dashendloc;
    public Vector3 dshlocver;
    public Vector3 corppos;
    public float dashspeed;
    public float dashdistance;
    public float dashtime;
    public float gravscale;
    Ray desh;
    public LayerMask layertohit;
    public bool shouldbedash;
    public bool isfacingright;



    // Start is called before the first frame update
    void Start()
    {
        horiz = Input.GetAxisRaw("Horizontal");
           
    }

    // Update is called once per frame
    void Update()
    {
       

        corppos.y = corp.position.y;
        corppos.x = corp.position.x;
       

        

        if (Input.GetKey(KeyCode.D)==true)
        {
            corp.velocity = new Vector2(1*movespeed,corp.velocity.y);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            RaycastHit2D dash = Physics2D.Raycast(corppos, corpus.right, dashdistance, layertohit);
            Debug.DrawLine(corp.transform.position, dash.point, Color.blue);
            dshlocver = dash.point;
            isfacingright = true;

        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            dshscript.transform.position = transform.position;
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            dshscript.transform.position = transform.position;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            corp.velocity = new Vector2(-1*movespeed, corp.velocity.y);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            RaycastHit2D dash = Physics2D.Raycast(corppos, corpus.right*-1, dashdistance, layertohit);
            Debug.DrawLine(corp.transform.position, dash.point, Color.blue);
            dshlocver = dash.point;
            isfacingright = false;
        }
        if (isfacingright == true)
        {
            RaycastHit2D dash = Physics2D.Raycast(corppos, corpus.right, dashdistance, layertohit);
            dshlocver = dash.point;
            Debug.DrawLine(corp.transform.position, dash.point, Color.blue);
        }
        else
        {
            RaycastHit2D dash = Physics2D.Raycast(corppos, corpus.right * -1, dashdistance, layertohit);
            dshlocver = dash.point;
            Debug.DrawLine(corp.transform.position, dash.point, Color.blue);
        }

        if (Input.GetKeyUp(KeyCode.A) ||Input.GetKeyUp(KeyCode.D))
        {
            corp.velocity = new Vector2(0, corp.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space) == true &script.isgrounded==true)
        {
            corp.velocity = Vector2.up*jumph;
            
        }

        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            shouldbedash = true;
            dashendloc.y = dshlocver.y;
            dashendloc.x = dshlocver.x;

        }
        if (shouldbedash == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, dashendloc, dashtime * Time.deltaTime);
            corp.gravityScale = 0;
      
        }
        if (corppos == dashendloc)
        {
            shouldbedash = false;
            corp.gravityScale = gravscale;
        }
        if (Input.GetKey(KeyCode.S))
        {
            colidplayer.isTrigger = true;
        }
        if (Input.GetKeyUp(KeyCode.S) == true)
        {
            colidplayer.isTrigger = false;
        }
       

    }
   public void Dash()
    {
        transform.position = Vector2.MoveTowards(transform.position, dashendloc, dashtime * Time.deltaTime);
    }
}


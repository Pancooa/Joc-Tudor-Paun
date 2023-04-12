using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helthbarboss : MonoBehaviour
{
    public GameObject containerhp;
    public bossdmgscript boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.hp < 1)
        {
            gameObject.SetActive(false);
            containerhp.SetActive(false);
        }
        transform.localScale = new Vector2(boss.hp/boss.maxhp, transform.localScale.y);
    }
}

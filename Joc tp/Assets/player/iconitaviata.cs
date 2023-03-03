using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iconitaviata : MonoBehaviour
{
    public health health;
    public SpriteRenderer sprite;
    public float hptinta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health.hp < hptinta)
        {
            sprite.enabled = false;
        }
        else
        {
            sprite.enabled = true;
        }

    }
}

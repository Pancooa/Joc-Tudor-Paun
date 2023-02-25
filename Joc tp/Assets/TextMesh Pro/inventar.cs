using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventar : MonoBehaviour
{


    public int Value = 10;
    public Text  ValueText;


    void Start()
    {
        



    }

    
    void Update()
    {


        ValueText.text = Value.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej5 : MonoBehaviour
{
    public int num1;
    public int num2;
    float res;

    void Start()
    {      
            if (num2 == 0)
            {
                Debug.Log("No se puede dividir por cero");
            }
            else
            {
                res = num1 / num2;
                Debug.Log(num1 + "/" + num2 + " = " + res);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

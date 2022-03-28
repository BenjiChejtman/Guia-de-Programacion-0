/* 2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,
respectivamente, realice la operación correspondiente y muestre el resultado en pantalla:
a.Suma
b.Producto */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej2 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int res1;
    int res2;
    
    void Start()
    {
        res1 = num1 + num2;
        Debug.Log("El resultado de la suma es " + res1);
        res2 = num1 * num2;
        Debug.Log("El resultado de la multiplicacion es " + res2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

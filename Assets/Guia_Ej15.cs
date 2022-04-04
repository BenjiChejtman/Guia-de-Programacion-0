using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej15 : MonoBehaviour
{
    public int num1;

    void Start()
    {

    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbas = false;
    bool noEstaEnNinguno = false;

    if (num1 % 2 > 0 || num1< 10 && num1> 0)
      {
        estaEnAmbas = true;
        Debug.Log("El numero ingresado contiene un solo digito y es impar.");
      }
    else if (num1 % 2 > 0)
      {
        estaEnB = true;
        Debug.Log("El numero ingresado es impar.");
      }
    else if (num1< 10 && num1> 0)
      {
        estaEnA = true;
        Debug.Log("El numero ingresado contiene un solo digito.");
      }
    else 
      {
        noEstaEnNinguno = true;
        Debug.Log("El numero ingresado no es impar y contiene mas de un digito.");
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

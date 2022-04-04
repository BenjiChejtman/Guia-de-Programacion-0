using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej14 : MonoBehaviour
{
    public string operacion;
    public int num1;
    public int num2;

    void Start()
    {
    switch (operacion)
    {
      case  "s": 
        Debug.Log(num1 + num2);
        break;
      case "r":
        Debug.Log(num1 - num2);
        Debug.Log(num2 - num1);
        break;
      case "p":
        Debug.Log(num1* num2);
        break;
      case "d":
        Debug.Log(num1 / num2);
        Debug.Log(num2 / num1);
        break;
    }
 }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

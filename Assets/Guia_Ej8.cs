﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej8 : MonoBehaviour
{
    public int dia = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        switch (dia)
        {                          //manera de evitar todos estos IF de arriba.
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Lunes");
                break;
            case 3:
                Debug.Log("Martes");
                break;
            case 4:
                Debug.Log("Miercoles");
                break;
            case 5:
                Debug.Log("Jueves");
                break;
            case 6:
                Debug.Log("Viernes");
                break;
            case 7:
                Debug.Log("Sabado");
                break;
            default:
                Debug.Log("El dia ingresado no es valido.");
                break;
        }

            }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

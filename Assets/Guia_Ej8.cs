using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej8 : MonoBehaviour
{
    public int dia= 0 ;

    // Start is called before the first frame update
    void Start()
    {
        if (dia == 1) 
        {
            Debug.Log("Hoy es Domingo.");
        }
        else if (dia == 2)
        {
            Debug.Log("Hoy es Lunes.");
        }
        else if (dia == 3)
        {
            Debug.Log("Hoy es Martes.");
        }
        else if (dia == 4)
        {
            Debug.Log("Hoy es Miercoles.");
        }
        else if (dia == 5)
        {
            Debug.Log("Hoy es Jueves");
        }
        else if (dia == 6)
        {
            Debug.Log("Hoy es Viernes");
        }
        else if (dia == 7)
        {
            Debug.Log(" Hoy es Sabado");
        }
        else
        {
            Debug.Log("El dia ingresado no es valido.");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

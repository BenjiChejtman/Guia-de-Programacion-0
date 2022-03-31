using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej10 : MonoBehaviour
{
    public int hora;
    int Hora_Apertura = 10;
    int Hora_Cierre = 18;
    bool estaAbierto;

    // Start is called before the first frame update
    void Start()
    {
        if (hora >= Hora_Apertura & hora <= Hora_Cierre)
        {
            estaAbierto = true;
            Debug.Log("El estacionamiento se encuentra abierto.");
        }
        else if (hora < Hora_Apertura & hora > Hora_Cierre)
        {
            estaAbierto = false;
            Debug.Log("El estacionamiento se encuentra cerrado.");
        }
        else
        {
            Debug.Log("Ha ingresado una hora incorrecta.");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
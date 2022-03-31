using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej9 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;
    public int aporte1;
    public int aporte2;
    public int aporte3;
    int total;
    int porcentaje1;
    int porcentaje2;
    int porcentaje3;


    // Start is called before the first frame update
    void Start()
    {
        total = aporte1 + aporte2 + aporte3;

        porcentaje1 = aporte1 * 100 / total;
        porcentaje2 = aporte2 * 100 / total;
        porcentaje3 = aporte3 * 100 / total;

        Debug.Log(nombre1 + ": capital aportado: $" + aporte1 + " , porcentaje del capital: %" + porcentaje1 + ", monto total aportado: $" + total);
        Debug.Log(nombre2 + ": capital aportado: $" + aporte2 + " , porcentaje del capital: %" + porcentaje2 + ", monto total aportado: $" + total);
        Debug.Log(nombre3 + ": capital aportado: $" + aporte3 + " , porcentaje del capital: %" + porcentaje3 + ", monto total aportado: $" + total);


    }

    // Update is called once per frame
    void Update()
    {

    }
}

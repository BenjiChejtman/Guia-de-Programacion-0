using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej13 : MonoBehaviour
{
    public int horas;
    int Salario;
    int HorasExtra;
    int PagaExtra;

    // Start is called before the first frame update
    void Start()
    {
      if (horas <= 40)
        {
          Salario = horas* 16;
          Debug.Log("Usted a trabajado " + horas + " y el salario que le corresponde es " + Salario + ".");
        }
      else if (horas > 40)
        {
          Salario = 40 * 16; // Le ponemos 40 por 16 ya que las horas que trabajo despues de las 40 entran en HorasExtra (y lo que gano en PagaExtra), y de esa forma se suma lo ganado en las 40 horas mas lo ganado en las horas extra.
          HorasExtra = horas - 40; // ej: trabajo 56 horas, entonces 56 - 40 es 16, por lo que trabajo 16 horas extra.
          PagaExtra = HorasExtra* 20; // A partir de saber cuantas horas extra trabajo, las multiplicamos por 20 para asi saber cuanto gano trabajando en esas horas extra.
          Salario = Salario + PagaExtra;
          Debug.Log("Usted a trabajado " + horas + " y el salario que le corresponde es " + Salario + ".");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

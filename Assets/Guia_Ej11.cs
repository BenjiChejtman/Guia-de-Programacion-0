using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia_Ej11 : MonoBehaviour
{
    public string FechaCompra;
    public string NombreComprador;
    public string NombreProducto;
    public int CantidadProducto;
    public int PrecioProducto;
    int Total;

    // Start is called before the first frame update
    void Start()
    {
        Total = PrecioProducto * CantidadProducto;

        Debug.Log("Fecha de compra: " + FechaCompra);
        Debug.Log("Nombre del comprador: " + NombreComprador);
        Debug.Log("Producto solicitado: " + NombreProducto);
        Debug.Log("Cantidad solicitada: " + CantidadProducto);
        Debug.Log("Precio unitario: " + PrecioProducto);
        Debug.Log("Total a pagar: " + Total);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


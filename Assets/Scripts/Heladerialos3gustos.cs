using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladerialos3gustos : MonoBehaviour
{

    public string codigoGusto;
    public int gramosHelado;

    float precioPorMilGramos = 500;
    float precioTotal;
    float porcentajeDescuento;

    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso t validación de datos

        if(gramosHelado < 250 || gramosHelado > 3000)
        {
            Debug.Log("Cantidad de helado no válida");
            return;

        }

        if (codigoGusto == "CHO" || codigoGusto == "DDL")
        {
            porcentajeDescuento = 0;
        }
        else if (codigoGusto == "FRU")
        {
            porcentajeDescuento = 10;
        }
        else
        {
            Debug.Log("Codigo gusto no valido");
            return;
        }

        precioTotal = gramosHelado * (precioPorMilGramos / 1000) * (1 - porcentajeDescuento / 100);
        Debug.Log("Por favor, paga" + precioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

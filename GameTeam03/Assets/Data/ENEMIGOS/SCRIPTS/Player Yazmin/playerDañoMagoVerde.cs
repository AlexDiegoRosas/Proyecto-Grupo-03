using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDaĆ±oMagoVerde : MonoBehaviour
{
    public int DaĆ±oAEnemigoMagoVerde;
    public GameObject EnemigoMagoVerde;
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            EnemigoMagoVerde.GetComponent<VidaEnemigoMagoVerde>().vidaEnemigoMagoVerde -= DaĆ±oAEnemigoMagoVerde;
            Debug.Log("Esto es un enemigo Mago Azul");
        }

       
    }
}

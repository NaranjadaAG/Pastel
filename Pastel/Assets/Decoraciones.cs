using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Decoraciones : MonoBehaviour
{
    public TMP_Dropdown DecoracionOpciones;
    public Image Decoracion;
    void Start()
    {
        DecoracionOpciones = GetComponent<TMP_Dropdown>();
        Decoracion = GameObject.Find("Decoracion").GetComponent<Image>();

    }

    public void DecoOptions()
    {
        switch (DecoracionOpciones.value)
        {
            case 0:
                Decoracion.color = Color.white;
                break;

            case 1:
                Decoracion.color = Color.blue;
                break;

            case 2:
                Decoracion.color = Color.black;
                break;

            case 3:
                Decoracion.color = Color.red;
                break;

            case 4:
                Decoracion.color = Color.yellow;
                break;

        }
    }


 
}

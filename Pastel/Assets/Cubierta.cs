using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cubierta : MonoBehaviour
{
    public TMP_Dropdown cubiertasOpciones;
    public Image Cubiertas;
    
    void Start()
    {
        cubiertasOpciones = GetComponent<TMP_Dropdown>();
        Cubiertas = GameObject.Find("Cubierta").GetComponent<Image>();

    }
    public void Saborcubierta()
    {
        switch (cubiertasOpciones.value)
        {
            case 0:

                Cubiertas.color = Color.black;

                break;

            case 1:

                Cubiertas.color = Color.red;

                break;

            case 2:

                Cubiertas.color = Color.yellow;

                break;

            case 3:

                Cubiertas.color = Color.green;

                break;

            case 4:

                Cubiertas.color = Color.blue;

                break;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Pasteles : MonoBehaviour
{
    public TMP_Dropdown pastelopciones;
    public Image Pastel;

     void Start()
    {
       pastelopciones = GetComponent<TMP_Dropdown>();
        Pastel = GameObject.Find("Pastel").GetComponent<Image>();

    }

    public void SaborPatel()
    {
        switch (pastelopciones.value)
        {
            case 0 :

                Pastel.color = Color.black;

                break;

            case 1:

                Pastel.color = Color.red;

                break;

            case 2:

                Pastel.color = Color.yellow;

                break;

            case 3:

                Pastel.color = Color.green;

                break;

            case 4:

                Pastel.color = Color.blue;

                break;
        }
    }

}

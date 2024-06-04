using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Toping : MonoBehaviour
{
    public TMP_Dropdown TopingOpciones;
    public Image Topings;

    void Start()
    {
        TopingOpciones = GetComponent<TMP_Dropdown>();
        Topings = GameObject.Find("Toping").GetComponent<Image>();
    }

    public void saborToping()
    {
        switch (TopingOpciones.value)
        {
            case 0:
                Topings.color = Color.white;
                break;

            case 1:
                Topings.color = Color.blue;
                break;

            case 2:
                Topings.color = Color.black;
                break;

            case 3:
                Topings.color = Color.red;
                break;

            case 4:
                Topings.color = Color.yellow;
                break;

        }
    }


  
}

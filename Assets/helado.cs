﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helado : MonoBehaviour
{

    public string saborHelado;
    public int gramos;
    int precio;
    
    void Start()
    {
        if (saborHelado != "DDL" && saborHelado != "FRU" && saborHelado != "CHO")
        {
            Debug.Log("Sabor de helado incorrecto");
            return;
        }
        if (gramos < 250 || gramos > 3000)
        {
            Debug.Log("Cantidad de gramos incorrecta");
            return;
        }
        if (saborHelado == "CHO" || saborHelado == "DDL")
        {


            precio = gramos / 2;

            Debug.Log("El precio es de " + precio);




        }
        else if (saborHelado == "FRU")
        {
            precio = (int)((gramos / 2) * 0.9f);
            Debug.Log("El precio es de " + precio);
        }
       

        }




    }
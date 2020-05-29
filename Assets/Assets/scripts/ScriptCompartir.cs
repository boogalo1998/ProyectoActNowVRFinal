using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCompartir : MonoBehaviour
{
    
    public  int CedulaFinal;
   
    void Update()
    {
        Login variable = GetComponent<Login>();
        CedulaFinal = variable.Cedula;
        Cargar();
    }

    void Cargar()
    {
        PlayerPrefs.SetInt("CedulaFinal", CedulaFinal);
        Debug.Log(PlayerPrefs.GetInt("CedulaFinal").ToString());
    }
}

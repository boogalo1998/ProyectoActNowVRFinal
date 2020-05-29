using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cambiosAlCubo : MonoBehaviour
{
    public static int puntaje = 0;
    public Text textoPuntaje;

    

    public void matar()
    {
        //puntaje = puntaje + 1;
        puntaje++;
        textoPuntaje.text = puntaje.ToString();
        Debug.Log("mi puntaje es " + puntaje);

        
        evaluarGanar(puntaje);
    }


    private void evaluarGanar(int marcador)
    {
        if (marcador >= 5)
        {
            Debug.Log("gané!!!!");
          
        }
    }

}

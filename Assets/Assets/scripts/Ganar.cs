using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ganar : MonoBehaviour
{
    private int Scene = 10;
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
        if (marcador >= 6)
        {
            Debug.Log("gané!!!!");
            SceneManager.LoadScene(Scene);

        }
    }
}

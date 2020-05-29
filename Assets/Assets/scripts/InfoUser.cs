using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    private string UrlLeer = "http://tadeolabhack.com:8081/test/Datos/ActNowPhp/leerActNow.php";



    public Text TextoNombre;


    private int Cedula = 0;


    public InputField campoCedula;

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {

        if (campoCedula.text != "")
        {
            Cedula = int.Parse(campoCedula.text);
        }
        else
        {
            print("el campo de edad no puede estar vacio");
        }

        string info = UrlLeer + "?cedu=" + Cedula;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);

        TextoNombre.text = resultInfo.text;




    }






}
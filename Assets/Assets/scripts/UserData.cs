using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/ActNowPhp/escribir.php";

  
    private string Nombre = "";
    private int Cedula = 0;
   

    public InputField campoNombre;
    public InputField campoCedula;




    public void SenData()
    {
        //es llamar a un metodo generando una pausa en la ejecución del programa hasta que se realiza lo que esta dentro del metodo
        StartCoroutine(enviarDatosUsuario());
    }

    private IEnumerator enviarDatosUsuario()
    {
        Nombre = campoNombre.text;
      

        if (campoCedula.text != "")
        {
            Cedula = int.Parse(campoCedula.text);
        }
        else
        {
            print("el campo de edad no puede estar vacio");
        }



        print(Nombre + "  " + Cedula  );


        if (Nombre == "" || Cedula == 0 )
        {
            print("los campos de nombre, apellido y edad deben tener información");
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("nombre", Nombre);
            form.AddField("cedula", Cedula);
          

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);

        }



    }
}

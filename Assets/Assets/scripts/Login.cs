using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public int Scene ;
    private string UrlLeer = "http://tadeolabhack.com:8081/test/Datos/ActNowPhp/leerLogin.php";
    public Text TextoNombre;
    public InputField txtNombre;
    public InputField campoCedula;
    public  int Cedula ;
    private string Rta;

   
    // Start is called before the first frame update
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
            print("el campo de cedula no puede estar vacio");
        }

        string info = UrlLeer + "?cedu=" + Cedula;

        WWW resultInfo = new WWW(info);

        yield return (resultInfo);

        print(resultInfo.text);

        Rta = resultInfo.text.Trim();

        //Debug.Log(resultInfo.text);

        if (Rta == "logeado")
        {
            print("el usuario si existe");
            SceneManager.LoadScene(Scene);

        }
        else if(Rta == "no existe el usuario")
        {
            print("el usuario no existe");
        }

        TextoNombre.text = Rta;

    }
    public void CerrarApp()
    {

        Application.Quit();
    }


    

}

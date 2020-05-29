using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botones : MonoBehaviour
{
    private string urlBotones = "http://tadeolabhack.com:8081/test/Datos/ActNowPhp/botonesEscribir.php?";
 
    private int IDitem = 0;
    public int IdUser ;
 

    void Start()
    {
         IdUser = PlayerPrefs.GetInt("CedulaFinal");
        
    }

    public void SelectIntem(int temp)
    {
        IDitem = temp;

        //es llamar a un metodo generando una pausa en la ejecución del programa hasta que se realiza lo que esta dentro del metodo
        StartCoroutine(sendItem());
    }

    private IEnumerator sendItem()
    {
        print(IDitem + "  " + IdUser);

        WWWForm form = new WWWForm();

        form.AddField("userID", IdUser);
        form.AddField("itemID", IDitem);

        WWW retroalimentacion = new WWW(urlBotones, form);

        yield return retroalimentacion;

        print(retroalimentacion.text);

       
    }
    
    








}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBotones : MonoBehaviour
{







    private string UrlClicks = "http://tadeolabhack.com:8081/test/Datos/ActNowPhp/ActNowBotonesInfo.php?";


    public Text TextClick;

    public int idUser;

    void Start()
    {
        idUser = PlayerPrefs.GetInt("CedulaFinal");

    }

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        

        string info2 = UrlClicks + "?IDuser=" + idUser;

        WWW resultInfo2 = new WWW(info2);

        yield return resultInfo2;
        print(resultInfo2.text);

        TextClick.text = resultInfo2.text;


    }







}

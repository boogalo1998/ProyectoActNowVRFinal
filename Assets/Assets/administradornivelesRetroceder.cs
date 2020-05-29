using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class administradornivelesRetroceder : MonoBehaviour
{
    public int Scene;
    public void irAjuego()
    {

        SceneManager.LoadScene(Scene);
    }

    public void CerrarApp()
    {

        Application.Quit();
    }
}

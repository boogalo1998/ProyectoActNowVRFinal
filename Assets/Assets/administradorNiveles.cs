using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles : MonoBehaviour {
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

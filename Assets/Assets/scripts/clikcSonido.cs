using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class clikcSonido : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        fuente.clip = clip;
    }

    // Update is called once per frame
   public  void PlaySound()
    {
        fuente.Play();
    }
}

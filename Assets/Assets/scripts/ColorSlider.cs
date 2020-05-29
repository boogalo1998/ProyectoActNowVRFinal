using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour
{
    public float red, green, yellow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RedChanged (float value)
    {
        this.red = value;
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        //SetColor();
    }
    public void GreenChanged(float value)
    {
        this.green = value;
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        //SetColor();
    }
    public void yellowChanged(float value)
    {
        this.yellow = value;
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        //SetColor();
    }

   /* public void SetColor()
    {
        this.gameObject.GetComponent<Renderer>().material.color =  Color.green;
    }*/
    
}

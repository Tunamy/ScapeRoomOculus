using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChages : MonoBehaviour
{

    public GameObject cubo;
    public AppVoiceExperience appvoice;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        appvoice.Activate();
    }

    public void UpdateColor(string[] values)
    {
        var colorstring = values[0];
       // var shapestring = values[1];

        if (colorstring == "rojo")
        {
            
            cubo.GetComponent<Renderer>().material.color = Color.red;
        }
            

        
    }
}

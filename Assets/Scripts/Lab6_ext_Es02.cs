using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab6_ext_Es02 : MonoBehaviour
{

    public enum Colore
    {
        ROSSO,
        GIALLO,
        VERDE,
        BLU
    }

    public Colore colorescelto = Colore.ROSSO;
    
    void cambioMateriali()
    {
        

        switch(colorescelto)
        {
            case Colore.ROSSO:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;

            case Colore.GIALLO:
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;

            case Colore.VERDE:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;

            case Colore.BLU:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            
            default:
                break;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cambioMateriali();
    }
}

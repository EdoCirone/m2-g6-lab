using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{

    public int numeroMax;
    private List<int>miaLista = new List<int>();

    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0;i<numeroMax; i++)
        {
            miaLista.Add(i);
            Debug.Log("ho aggiunto" + i + "ora la lista è " + miaLista);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}

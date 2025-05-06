using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{

    public int numeroMax;
    private List<int> miaLista = new List<int>();

    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i <= numeroMax; i++)
        {
            int n = i + 1;
            if (n % 3 == 0)
            {
                miaLista.Insert(miaLista.Count / 2, i);
                Debug.Log("ho aggiunto " + i + "ora la lista è " + string.Join(", ", miaLista));

            }

            else if (n % 3 == 2)
            {
                miaLista.Add(i);
                Debug.Log("ho aggiunto" + i + "ora la lista è " + string.Join(", ", miaLista));
            }

            else
            {
                miaLista.Insert(0, i);
                Debug.Log("ho aggiunto " + i + "ora la lista è " + string.Join(", ", miaLista));
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
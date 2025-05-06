using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitchBehaviour : MonoBehaviour
{

    public enum STATE
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED
    }

    public STATE state;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        switch (state)
        {

            case STATE.IDLE:
                Debug.Log("il nemico è fermo");
                break;
            case STATE.ATTACKING:
                Debug.Log("il nemico sta attaccando");
                break;
            case STATE.DEFEATED:
                Debug.Log("il nemico è sconfitto");
                break;
            case STATE.AGGROED:
                Debug.Log("il nemico sta inseguendo");
                break;





        }


    }
}

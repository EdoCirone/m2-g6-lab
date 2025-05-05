using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Puppet : MonoBehaviour
{
    public int PuppetsNumber = 10;
    public GameObject puppet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            float x = Random.Range(-10,10);
            float y = Random.Range(-10,10);
            float z = Random.Range(-10,10);

            Vector3 pos = new Vector3 (x, y, z);

            GameObject puppetclone = Instantiate(puppet, pos, Quaternion.identity);

    }
}

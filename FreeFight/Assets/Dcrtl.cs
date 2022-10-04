using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dcrtl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "W")
        {
            Destroy(other.gameObject);
            SpawnR spawnR = new SpawnR();
            spawnR.enemycount += 1;
        }
    }
}

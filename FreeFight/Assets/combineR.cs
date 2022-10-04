using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combineR : MonoBehaviour
{
    Transform me;

    int xx = 1, yy = 1 , zz= 1;
    // Start is called before the first frame update
    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {
        me = GetComponent<Transform>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "X")
        {
            

        }
    }

}

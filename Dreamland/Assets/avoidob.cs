using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class avoidob : MonoBehaviour
{
    Transform mtarget;
    Transform entity;

    // Start is called before the first frame update
    void Start()
    {
        mtarget = GameObject.FindGameObjectWithTag("Col").transform;
        entity = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}

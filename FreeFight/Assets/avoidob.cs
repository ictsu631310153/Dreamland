using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avoidob : MonoBehaviour
{
    Transform mtarget;
    Transform entity;
    // Start is called before the first frame update
    void Start()
    {
        entity = GetComponent<Transform>();
        mtarget = GameObject.FindGameObjectWithTag("Col").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (mtarget.position.x - 1 > entity.position.x)
        {
           
        }
    }
    
}

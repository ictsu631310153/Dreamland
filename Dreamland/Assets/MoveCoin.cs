using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoin : MonoBehaviour
{
    Vector3 entity;
    float UD = 1;
    // Start is called before the first frame update
    void Start()
    {
        entity = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y > entity.y + 10)
        {
            UD = -1;
        }
        if (transform.position.y < entity.y - 10)
        {
            UD = 1;
        }
  
        transform.Translate(UD * Time.deltaTime * 4f, 0, 0);
        
    }
}

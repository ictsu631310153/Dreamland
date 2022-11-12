using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public GameObject Warn;
    Transform mtarget;
    Transform entity;
    // Start is called before the first frame update
    void Start()
    {
        
        mtarget = GameObject.FindGameObjectWithTag("Player").transform;
        entity = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mtarget.position.x +20 > entity.position.x)
        {
            StartCoroutine(triggerwarn());
            
        }
        if (mtarget.position.x > entity.position.x)
        {
            
           
        }
    }
    IEnumerator triggerwarn()
    {
        transform.Translate(0, -1 * 10f * Time.deltaTime, 0);
        yield return new WaitForSeconds(2f);
        Warn.SetActive(false);
    }


}

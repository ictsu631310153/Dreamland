using UnityEngine;
using System.Collections;

public class LeftBehide : MonoBehaviour
{
    
    public Material[] materials;
    Renderer rend;
    Transform mtarget;
    Transform entity;
    Transform ob;
    public float timex;
    public bool move=false;
    public bool dash = false;
    public float timed;
    public float mSpeed = 9f;
   
    // Start is called before the first frame update
    void Start()
    {
        mtarget = GameObject.FindGameObjectWithTag("Player").transform;
        entity = GetComponent<Transform>();
        ob = GetComponent<Transform>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
        timex = timex + Time.deltaTime;
        

    }
    void Update()
    {
        timex = timex + Time.deltaTime;
        if (mtarget.position.x - 1 > entity.position.x)
        {



            
                StartCoroutine(ExampleCoroutine());


        }
        if (move == true)
        {

            timex = timex + Time.deltaTime;
            timed = 2;
            if (timex > 3)
            {
                mSpeed = mSpeed + 0.5f;
                timex = 0;
            }
            gameObject.tag = "X";
            rend.sharedMaterial = materials[1];
            transform.LookAt(mtarget.position);
            transform.Translate(0f, 0f, mSpeed * Time.deltaTime);


        }
        if (ob.position.x - 1 > entity.position.x)
        {

        }


    }
    // Update is called once per frame

    IEnumerator ExampleCoroutine()
    {


        
        if (dash == false)
        {
            
            gameObject.tag = "X";
            rend.sharedMaterial = materials[1];
            transform.LookAt(mtarget.position);
            yield return new WaitForSeconds(1f);
            transform.Translate(0f, 0f, (mSpeed + 5f) * Time.deltaTime);
            yield return new WaitForSeconds(0.2f);
            
            dash = true;
        }
        if (dash == true)
        {
            
            
            transform.Translate(0f, 0f, 0f);
            yield return new WaitForSeconds(0.5f);
            move = true;
        }
        if (true)
        {

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
    }
    
}

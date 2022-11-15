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
    public float mSpeed;
    Playermovement playerm;
   
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
        
        mSpeed = Playermovement.mSpeed - 1.5f;
        transform.LookAt(mtarget.position);
        timex = timex + Time.deltaTime;
        if (mtarget.position.x - 1.5 > entity.position.x)
        {



            
                StartCoroutine(ExampleCoroutine());


        }
        if (move == true)
        {

            timex = timex + Time.deltaTime;
            timed = 2;
            if (mSpeed<18.5)
            {
                if (timex > 5)
                {
                    mSpeed = mSpeed + 1f;
                    timex = 0;
                }
            }
            else
            {
                mSpeed = 18.5f;
            }
            
            gameObject.tag = "X";
            rend.sharedMaterial = materials[1];
            transform.LookAt(mtarget.position);
            transform.Translate(0f, 0f, mSpeed * Time.deltaTime);

            
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
            yield return new WaitForSeconds(1.5f);
            transform.Translate(0f, 0f, (mSpeed + 3f) * Time.deltaTime);
            yield return new WaitForSeconds(0.1f);
            
            dash = true;
        }
        if (dash == true)
        {
            
            
            transform.Translate(0f, 0f, 0f);
            yield return new WaitForSeconds(0.5f);
            move = true;
        }
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mSpeed = 0;
        }
        if (other.gameObject.tag == "Col")
        {
            Destroy(other.gameObject);
        }
    }

}

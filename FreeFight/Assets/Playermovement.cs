using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{ 
    
    public bool xxe;
    public GameObject losepanael;
    public GameObject winpanael;
    public GameObject warn;
    public float timex,timexg,durations;
    public float UD, mSpeed = 10.0f;
    public float spdt;
    public bool boost;
    public Material[] material;
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(0, 0, 1 * Time.deltaTime * mSpeed);
        UD = Input.GetAxis("Vertical");
        transform.Translate(0, UD * Time.deltaTime * mSpeed, 0);
        timex = timex + Time.deltaTime;
        durations = durations - Time.deltaTime;
        
        if (timex > 7)
        {
            
            mSpeed = mSpeed + 0.5f;
            timex = 0;
        }
        if (boost == true)
        {
            if (durations<0)
            {
                boost = false;
                mSpeed = mSpeed - 10f;
            }
        }
        
        


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "W")
        {
            Destroy(other.gameObject);
            PointManage.pointValue = PointManage.pointValue + 1;
        }
        if (other.gameObject.tag == "X")
        {

            rend.sharedMaterial = material[1];
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Col")
        {

            rend.sharedMaterial = material[1];
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
            starcount.startValue = starcount.startValue + 1;


        }
        if (other.gameObject.tag == "A")
        {
            Destroy(other.gameObject);
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("X");
            foreach (GameObject target in gameObjects)
            {
                GameObject.Destroy(target);
            }
        }
        if (other.gameObject.tag == "SSSS")
        {
            if (starcount.startValue >= 3)
            {
                winpanael.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                losepanael.SetActive(true);
                Time.timeScale = 0;
            }


        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boost")
        {
            boost = true;
            mSpeed = mSpeed + 10f;
            durations = 2f;
            Destroy(collision.gameObject);

        }
    }



}

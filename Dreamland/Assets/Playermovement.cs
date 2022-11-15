using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{ 
    
    public bool xxe;
    public GameObject losepanael;
    public GameObject winpanael;
    public GameObject pause;
    public float timex,timexg,durations;
    public float UD, mSpeed = 10.0f;
    public float spdt;
    public bool boost;
    public Material[] material;
    public Animator e;
    Renderer rend;
    bool Hitsc;
    LeftBehide left;
    public static bool gameP = false;

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameP)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        


    }
    void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        gameP = false;
    }
    void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        gameP = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "W")
        {

            Destroy(other.gameObject);
            StartCoroutine(Grab());
            PointManage.pointValue = PointManage.pointValue + 1;
            mSpeed += 0.2f;
        }
        if (other.gameObject.tag == "Star")
        {

            Destroy(other.gameObject);
            StartCoroutine(Grab());
            starcount.startValue = starcount.startValue + 1;
        }
        if (other.gameObject.tag == "A")
        {
            StartCoroutine(Grab());
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
        if (other.gameObject.tag == "Col")
        {

            StartCoroutine(Hit());
            StartCoroutine(desSpeed());
        }
        if (other.gameObject.tag == "X")
        {

            StartCoroutine(dead());
        }
        if (other.gameObject.tag == "Boost")
        {
            StartCoroutine(Speed());
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "Dead")
        {
            StartCoroutine(dead());

        }

        IEnumerator Hit()
        {
            e.SetBool("Hit", true);
            yield return new WaitForSeconds(0f);
            e.SetBool("Hit", false);
        }
        IEnumerator Grab()
        {
            e.SetBool("Grab", true);
            yield return new WaitForSeconds(0f);
            e.SetBool("Grab", false);
        }
        IEnumerator dead()
        {

            e.SetBool("Hit", true);
            yield return new WaitForSeconds(0f);
            e.SetBool("Hit", false);
            yield return new WaitForSeconds(0.25f);
            losepanael.SetActive(true);
            Time.timeScale = 0;
        }
        IEnumerator Speed()
        {
            mSpeed += 6;
            yield return new WaitForSeconds(1.5f);
            mSpeed -= 6;
        }
        IEnumerator desSpeed()
        {
            mSpeed -= 5;
            yield return new WaitForSeconds(1.5f);
            mSpeed += 5;
        }

    }
}

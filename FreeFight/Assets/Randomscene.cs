using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomscene : MonoBehaviour
{
    public GameObject[] section;
    public int xpos = 250;
    public int sectioncount = 0;
    public bool countscene = false;
    public bool creatingsection = false;
    public int secNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        if (creatingsection == false)
        {
            if (countscene == false)
            {
                creatingsection = true;
                StartCoroutine(GenarateSection());
            }
            else if(countscene == true)
            {
                creatingsection = false;
            }
            
        }
    }
    IEnumerator GenarateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(xpos, 15, 60), Quaternion.identity);
        xpos += 250;
        sectioncount += 1;
        if (sectioncount == 4)
        {
            countscene = true;
        }
        yield return new WaitForSeconds(2);
        creatingsection = false;


    }
}

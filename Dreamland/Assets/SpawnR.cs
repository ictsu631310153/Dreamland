using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnR : MonoBehaviour
{
    public GameObject Ene;
    public GameObject D;
    public GameObject Star;
    public GameObject Speeds;
    int expos = -25, ypos, dxpos = 185;
    int starxpos = 280;
    public int enemycount;
    public int itcount;
    public int starcount;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
        StartCoroutine(EitDrop());
        StartCoroutine(StarDrop());
        
    }

    // Update is called once per frame
  
    IEnumerator EnemyDrop()
    {
        while(enemycount < 50)
        {
            
            ypos = Random.Range(0, 22);
            Instantiate(Ene, new Vector3(expos, ypos, 0), Quaternion.identity);
            expos += 25;
            
            yield return new WaitForSeconds(0.2f);
            enemycount += 1;
        }
        
    }
    IEnumerator EitDrop()
    {
        while (itcount < 4)
        {

            ypos = Random.Range(0, 22);
            Instantiate(D, new Vector3(dxpos, ypos, 0), Quaternion.identity);
            dxpos += 200;
            yield return new WaitForSeconds(0.2f);
            itcount += 1;
            
        }
    }
    IEnumerator StarDrop()
    {
        while (starcount < 4)
        {

            ypos = Random.Range(0, 22);
            Instantiate(Star, new Vector3(starxpos, ypos, 0), Quaternion.identity);
            starxpos += 200;
            yield return new WaitForSeconds(0.2f);
            starcount += 1;

        }
    }
    //IEnumerator Speed()
    //{
    //    while (speed < 3)
    //    {

    //        ypos = Random.Range(0, 22);
    //        Instantiate(Speeds, new Vector3(expos, ypos, 0), Quaternion.identity);
    //        expos += 520;

    //        yield return new WaitForSeconds(0.2f);
    //        speed += 1;
    //    }

    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointManage : MonoBehaviour
{
    public static int pointValue = 0;
    Text pointtext;
    
    void Start()
    {
        pointtext = GetComponent<Text>();
        pointtext.text = "Point : " + pointValue;
    }

    // Update is called once per frame
    void Update()
    {
        pointtext.text = "Point : " + pointValue;
    }
}

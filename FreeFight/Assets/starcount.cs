using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starcount : MonoBehaviour
{
    public static int startValue = 0;
    Text starttext;

    void Start()
    {
        starttext = GetComponent<Text>();
        starttext.text = "Star : " + startValue;
    }

    // Update is called once per frame
    void Update()
    {
        starttext.text = "Star : " + startValue;
    }
}

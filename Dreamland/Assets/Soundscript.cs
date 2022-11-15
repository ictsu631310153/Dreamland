using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundscript : MonoBehaviour
{
    // Start is called before the first frame update
    private static Soundscript bgm;

    private void Awake()
    {
        if (bgm == null)
        {
            bgm = this;
            DontDestroyOnLoad(bgm);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

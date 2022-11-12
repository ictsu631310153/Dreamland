using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Slider Vol;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("mmusicVol"))
        {
            PlayerPrefs.SetFloat("musicVol", 1);
            load();
        }
        else
        {
            load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VolSetting()
    {
        AudioListener.volume = Vol.value;
    }
    private void load()
    {
        Vol.value = PlayerPrefs.GetFloat("musicVol");
    }
    private void save()
    {
        PlayerPrefs.SetFloat("musicVol", Vol.value);
    }
}

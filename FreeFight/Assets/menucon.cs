using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucon : MonoBehaviour
{
    public void GameMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionStart()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucon : MonoBehaviour
{
    public GameObject soundgame;
    public void GameMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void GameStart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void OptionStart()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void Optionpause()
    {
        soundgame.SetActive(true);

    }
    public void resume()
    {
        soundgame.SetActive(false);
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

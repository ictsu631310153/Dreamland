using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucon : MonoBehaviour
{
    public GameObject soundgame;
    public static bool closeops = false;
    starcount star;
    public void GameMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void GameJHow()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void GameStart()
    {

        SceneManager.LoadScene(2);
        Time.timeScale = 1;
        starcount.startValue = 0;
        Cursor.visible =false;
    }
    public void OptionStart()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void Optionpause()
    {
        soundgame.SetActive(true);
        closeops = true;
        Cursor.visible = true;
    }
    public void resume()
    {
        soundgame.SetActive(false);
        closeops = false;
        Cursor.visible = true;
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

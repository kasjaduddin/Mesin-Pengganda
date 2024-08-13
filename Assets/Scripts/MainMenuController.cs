using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    void Awake()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("RouterScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

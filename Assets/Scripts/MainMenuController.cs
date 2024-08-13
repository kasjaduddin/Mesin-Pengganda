using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> CreditPages;
    int currentCreditPage;
    void Awake()
    {
        Cursor.visible = false;
    }
    private void Start()
    {
        currentCreditPage = 0;
    }
    void Update()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene("RouterScene");
    }
    public void NextCredit() 
    {
        if (currentCreditPage != (CreditPages.Count - 1))
        {
            
        }
    }
    public void PreviousCredit() 
    {
        if (currentCreditPage != 0)
        {
            
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}

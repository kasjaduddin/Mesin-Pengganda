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
        CreditPages[currentCreditPage].SetActive(false);
        if (currentCreditPage != (CreditPages.Count - 1))
            currentCreditPage++;
        else
            currentCreditPage = 0;
        CreditPages[currentCreditPage].SetActive(true);
    }
    public void PreviousCredit() 
    {
        CreditPages[currentCreditPage].SetActive(false);
        if (currentCreditPage != 0)
            currentCreditPage--;
        else
            currentCreditPage = CreditPages.Count - 1;
        CreditPages[currentCreditPage].SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interacable : MonoBehaviour
{
    private Outline ObjectOutline;
    [SerializeField]
    private string message;
    [SerializeField]
    private UnityEvent OnInteraction;
    // Start is called before the first frame update
    void Start()
    {
        ObjectOutline = GetComponent<Outline>();
        DisableOutline();
    }
    public void Interact()
    {
        OnInteraction.Invoke();
    }
    public void DisableOutline()
    {
        ObjectOutline.enabled = false;
    }
    public void EnableOutline()
    {
        ObjectOutline.enabled = true;
    }
}

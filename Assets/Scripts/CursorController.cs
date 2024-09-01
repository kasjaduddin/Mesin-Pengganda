using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public RectTransform cursorRectTransform;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        cursorRectTransform.position = new Vector2(Screen.width / 2, Screen.height / 2);
    }
}

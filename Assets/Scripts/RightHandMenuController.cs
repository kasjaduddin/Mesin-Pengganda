﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RightHandMenuController : MonoBehaviour
{
    public GameObject LeftHand;
    private void Start()
    {
        LeftHand.SetActive(false);
    }
    private void Update()
    {
        setCursor();
    }
    private void setCursor()
    {
        if (Input.mousePosition.x >= Screen.width / 2)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane + 0.2f));
            transform.position = worldPosition;
        }
        else
        {
            LeftHand.SetActive(true);
            gameObject.SetActive(false);
        }
        Debug.Log(Input.mousePosition.x);
    }
}
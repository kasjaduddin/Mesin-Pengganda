using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SetCanvas();
    }
    private void SetCanvas()
    {
        Camera camera = Camera.main;
        GameObject canvas = GameObject.Find("Tutorial Canvas");

        SetCanvasRotation(camera, canvas);
    }
    private void SetCanvasRotation(Camera camera, GameObject canvas)
    {
        canvas.transform.rotation = camera.transform.rotation;
        Vector3 newPosition = camera.transform.position + camera.transform.forward * 2f;
        canvas.transform.position = newPosition;
    }
    public void entPoin()
    {
        Debug.Log("IMG");
    }
    public void entPoin1()
    {
        Debug.Log("BTN");
    }
}

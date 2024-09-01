using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private float playerReach;
    private Interacable CurrentInteracable;

    // Start is called before the first frame update
    void Start()
    {
        playerReach = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInteraction();
        if (Input.GetKeyDown(KeyCode.K) && CurrentInteracable != null)
        {
            CurrentInteracable.Interact();
        }
    }
    private void CheckInteraction()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if(Physics.Raycast(ray, out hit, playerReach)) 
        {
            if (hit.collider.tag == "Interacable")
            {
                Interacable newInteracable = hit.collider.GetComponent<Interacable>();

                if (newInteracable.enabled)
                {
                    SetNewCurrentInteracable(newInteracable);
                }
                else
                {
                    DisableCurrentInteracable();
                }
            }
            else
            {
                DisableCurrentInteracable();
            }
        }
        else
        {
            DisableCurrentInteracable();
        }
    }
    private void SetNewCurrentInteracable(Interacable newInteracable)
    {
        CurrentInteracable = newInteracable;
        CurrentInteracable.EnableOutline();
    }
    private void DisableCurrentInteracable()
    {
        if( CurrentInteracable) 
        {
            CurrentInteracable.DisableOutline();
            CurrentInteracable = null;
        }
    }
}

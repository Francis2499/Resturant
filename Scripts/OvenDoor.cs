using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject OvenDoorHandle;
    [SerializeField]
    private GameObject OvenDoorCollider;
    private bool isDoorClosed =true;
    [SerializeField]
    private Oven Oven;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            isDoorClosed = true;
            Oven.Cook();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            isDoorClosed = false;
           
        }
    }


    public bool GetIsDoorClosed()
    {
        return isDoorClosed;
    }
}

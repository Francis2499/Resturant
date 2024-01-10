using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{
    [SerializeField]
    private GameObject OvenGO;

    private bool isDoorClosed;
    [SerializeField]
    private OvenDoor OvenDoor;
    private Tray tray;

    private void Start()
    {
        isDoorClosed = OvenDoor.GetIsDoorClosed();
    }


    //void Cook()
    //{
    //    if (isDoorClosed)
    //    {
    //        for (int i = 0; i < OvenGO.transform.childCount; i++)
    //        {
    //            GameObject trayGO = OvenGO.transform.GetChild(i).gameObject;
    //            for (int j = 0; j < trayGO.transform.childCount; j++)
    //            {
    //                Cookie[] childscripts = trayGO.GetComponentsInChildren<Cookie>();

    //                for (int k = 0; k < childscripts.Length; k++)
    //                {
    //                    Cookie currentCookie = childscripts[i];
    //                    currentCookie.Cook_Cookie();
    //                }

    //            }
    //        }

    //        Debug.Log("Function Activated");
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        tray = other.GetComponent<Tray>();
        Debug.Log("Collider Working");
    }

    public void Cook()
    {
        Debug.Log("Cooking" + isDoorClosed);
        if(isDoorClosed)
        {
          tray.CookieCook();
        }

    }
}

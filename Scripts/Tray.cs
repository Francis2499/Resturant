using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tray : MonoBehaviour
{
    [SerializeField]
    private GameObject tray;
    // Start is called before the first frame update
    public void CookieCook()
    {
        Debug.Log("Cookie Cook");

        for (int j = 0; j < tray.transform.childCount; j++)
        {
            Cookie[] childscripts = tray.GetComponentsInChildren<Cookie>();

            for (int k = 0; k < childscripts.Length; k++)
            {
                Cookie currentCookie = childscripts[k];
                currentCookie.Cook_Cookie();
            }

        }
        Debug.Log("Function Activated");
    }

    
    }


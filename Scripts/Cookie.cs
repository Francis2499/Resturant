using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Cookie : MonoBehaviour
{
    [SerializeField]
    private int cookieID = 0;

    [SerializeField]
    private GameObject cooked;

    [SerializeField]
    private GameObject unCooked;

    [SerializeField]
    private GameObject cooked_Loaded;

    [SerializeField]
    private GameObject Kinder;

    [SerializeField]
    private GameObject Nutella_Oero;

    [SerializeField]
    private GameObject burnt_cookie;
    [SerializeField]
    private GameObject socketGO;



    [SerializeField]
    private bool isCooked = false;

    [SerializeField]
    private bool isNutella = false;

    [SerializeField]
    private bool isLoaded = false;

    [SerializeField]
    private bool isBurnt = false;
    [SerializeField]
    XRSocketInteractor socket;
    public int GetCookieID()
    {
        return cookieID;
    }
    public void SetCookieID(int value)
    {
        cookieID = value;
    }

    private void Start()
    {
    }

    private void Update()
    {
        //SocketCheck();
    }
    public void Cook_Cookie()
    {

        unCooked.SetActive(false);
        cooked.SetActive(true);
        //SocketCheck();
    }

   
    public void SocketCheck()
    {
        unCooked.SetActive(false);
        cooked.SetActive(true);
        //IXRSelectInteractable objName = socket.GetOldestInteractableSelected();
        //Debug.Log(objName.transform.name);

        //Cookie cookie = objName.transform.GetComponent<Cookie>();

        //unCooked.SetActive(false);
        //cooked.SetActive(true);

        //if (cookie.cookieID == 1)
        //{
        //    unCooked.SetActive(false);
        //    cooked_Loaded.SetActive(true);
        //    SetCookieID(5);
        //}
        //else if(cookie.cookieID == 2)
        //{
        //    unCooked.SetActive(false);
        //    cooked_Loaded.SetActive(true);
        //    SetCookieID(6);
        //}
        //else if(cookie.cookieID == 3)
        //{
        //    unCooked.SetActive(false);
        //    burnt_cookie.SetActive(true);

        //}
        //else if(cookieID == 5)
        //{
        //    cooked_Loaded.SetActive(false);
        //    Kinder.SetActive(true);
        //}
        //else if(objName.transform.CompareTag("Oreo") && cookieID == 6)
        //{
        //    cooked_Loaded.SetActive(false);
        //    Nutella_Oero.SetActive(true);
        //}
        //else
        //{
        //    unCooked.SetActive(false);
        //    cooked.SetActive(true);
        //}
       
    }
}

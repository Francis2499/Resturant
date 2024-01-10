using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie2 : MonoBehaviour
{
    [SerializeField]
    private GameObject cooked;

    [SerializeField]
    private GameObject unCooked;

    [SerializeField]
    private GameObject burnt;

    private bool iscooked=false;
    public void Cook_Cookie()
    {
        if(!iscooked)
        {
            cooked.SetActive(true);
            unCooked.SetActive(false);
            iscooked = true;
        }

        else if (iscooked)
        {

            burnt.SetActive(true);
            cooked.SetActive(false);
        }
    }
}

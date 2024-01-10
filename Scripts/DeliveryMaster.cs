using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryMaster : MonoBehaviour
{
    [SerializeField]
    private Transform m_ContentContainer;

    [SerializeField]
    private GameObject m_ItemPrefab;

    [SerializeField]
    private int m_ItemsToGenerate;
    private Text newText;

    public bool OrderCompleted = false;

    [SerializeField]
    private GameObject TillUI;

    [SerializeField]
    private GameObject TillDrawer;

    [SerializeField]
    private GameObject CashUI;

    private void Start()
    {
        for(int i=0; i< m_ItemsToGenerate; i++)
        {
            var item_go = Instantiate(m_ItemPrefab);
            newText = item_go.GetComponentInChildren<Text>();
                newText.text = "Kinder";
            item_go.transform.SetParent(m_ContentContainer);
            item_go.transform.localScale = Vector2.one;
        }
    }

    public void OrderComplete()
    {
        OrderCompleted = true;
        if (OrderCompleted)
        {
            Debug.Log("We are in!");
            TillUI.SetActive(true);
        }
    }
    public void NewOrder()
    {
        newText.text = "Milk Choc";
        OrderCompleted = false;
        TillUI.SetActive(false);
        TillDrawer.transform.position = new Vector3(-2.66f, 0, -0.313f);
        CashUI.SetActive(false);
    }
}

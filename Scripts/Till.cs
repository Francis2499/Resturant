using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Till : MonoBehaviour
{
    [SerializeField]
    private Transform m_ContentContainer;

    [SerializeField]
    private GameObject m_ItemPrefab;
    private Text newText;

    [SerializeField] GameObject queueContents = null;

    private float TotalAmount = 0;
    [SerializeField]
    private Text TotalText;
    [SerializeField]
    private GameObject TillDrawer;
    [SerializeField]
    private GameObject CashUI;


    public void ClickKinderChoc()
    {
        Debug.Log("hi");
        var item_go = Instantiate(m_ItemPrefab);
        newText = item_go.GetComponentInChildren<Text>();
        newText.text = "Kinder";
        item_go.transform.SetParent(m_ContentContainer);
        item_go.transform.localScale = Vector2.one;
        TotalAmount += 2.6f;
        TotalText.text = "Total:"+ TotalAmount.ToString();
    }

    public void ClickOreo()
    {
        Debug.Log("hi");
        var item_go = Instantiate(m_ItemPrefab);
        newText = item_go.GetComponentInChildren<Text>();
        newText.text = "Oreoi&Nutella";
        item_go.transform.SetParent(m_ContentContainer);
        item_go.transform.localScale = Vector2.one;
        TotalAmount += 2.6f;
        TotalText.text = "Total:" + TotalAmount.ToString();
    }
    public void ClickMilkChoc()
    {
        Debug.Log("hi");
        var item_go = Instantiate(m_ItemPrefab);
        newText = item_go.GetComponentInChildren<Text>();
        newText.text = "Milk Choc";
        item_go.transform.SetParent(m_ContentContainer);
        item_go.transform.localScale = Vector2.one;
        TotalAmount += 1;
        TotalText.text = "Total:" + TotalAmount.ToString();
    }
    public void ClickWhiteChoc()
    {
        Debug.Log("hi");
        var item_go = Instantiate(m_ItemPrefab);
        newText = item_go.GetComponentInChildren<Text>();
        newText.text = "White Choc";
        item_go.transform.SetParent(m_ContentContainer);
        item_go.transform.localScale = Vector2.one;
        TotalAmount += 1;
    }

    public void ClickDoubleChoc()
    {
        Debug.Log("hi");
        var item_go = Instantiate(m_ItemPrefab);
        newText = item_go.GetComponentInChildren<Text>();
        newText.text = "Double Choc";
        item_go.transform.SetParent(m_ContentContainer);
        item_go.transform.localScale = Vector2.one;
        TotalAmount += 1;
    }


    public void ClearChildren()
    {
        foreach(RectTransform child in queueContents.transform)
    {
            Destroy(child.gameObject);
        }

        TotalAmount = 0; 
        TotalText.text = "Total:" + TotalAmount.ToString();
    }

    public void Pay()
    {
        if(TotalAmount == 2.6f)
        {
            TillDrawer.transform.position = new Vector3(-2.66f, 0, -0.813f);
            CashUI.SetActive(true);
        }   
    }
}

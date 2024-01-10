using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashDetector : MonoBehaviour
{
    public float radius = 5f;

    public float change = 0;
    [SerializeField]
    private DeliveryMaster deliveryMaster;
    [SerializeField]
    private Text newText;

    private void Start()
    {
        newText.text = "Change Given out:" + change;
    }

    private void OnTriggerEnter(Collider other)
        {
        // Get all colliders within the specified radius
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        // Loop through all colliders and check if they are game objects
        foreach (Collider collider in colliders)
        {
            GameObject gameObject = other.gameObject;

            // Do something with the game object
            Debug.Log(gameObject.name);
            if (gameObject.CompareTag("20 note"))
            {
                Debug.Log("20 note");
                change += 20;
            }
            if (gameObject.CompareTag("10 note"))
            {
                Debug.Log("20 note");
                change += 10;
            }
            if (gameObject.CompareTag("5 note"))
            {
                Debug.Log("5 note");
                change += 5;
            }
            if (gameObject.CompareTag("1 coin"))
            {
                Debug.Log("1 Coin");
                change += 1;
            }

            if (change == 2)
            {
                Debug.Log("change complete");
                deliveryMaster.NewOrder();

            }
        }
        newText.text = ("Change Given out:"+ change);

    }
    private void OnTriggerExit(Collider other)
    {
        // Get all colliders within the specified radius
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        // Loop through all colliders and check if they are game objects
        foreach (Collider collider in colliders)
        {
            GameObject gameObject = other.gameObject;

            // Do something with the game object
            Debug.Log(gameObject.name);
            if (gameObject.CompareTag("20 note"))
            {
                Debug.Log("20 note");
                change -= 20;
            }
            if (gameObject.CompareTag("10 note"))
            {
                Debug.Log("20 note");
                change -= 10;
            }
            if (gameObject.CompareTag("5 note"))
            {
                Debug.Log("5 note");
                change -= 5;
            }
            if (gameObject.CompareTag("1 coin"))
            {
                Debug.Log("1 Coin");
                change -= 1;
            }
            newText.text = ("Change Given out:" + change);
        }
    }

    // Visualize the detection area in the scene view
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDetector : MonoBehaviour
{
    public float radius = 5f;
    [SerializeField]
    private DeliveryMaster deliveryMaster;



    private void OnTriggerEnter(Collider other)
    {
            GameObject gameObject = other.gameObject;

            // Do something with the game object
            Debug.Log(gameObject.name);
            if((String.Equals(gameObject.name,"Kinder Cookie")))
            {
            
            deliveryMaster.OrderComplete();
            gameObject.SetActive(false);
            }
  
        
    }

    // Visualize the detection area in the scene view
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
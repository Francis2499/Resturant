using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject PositionToSpawn;

    public void SpawnMoney()
    {
        Debug.Log("Spawning Cookie");
        Instantiate(prefab, PositionToSpawn.transform.position, transform.rotation);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "20 note")
    //    {
    //        Destroy(collision.gameObject);
    //        Debug.Log("Deleteing Money");
    //    }
    //}
}

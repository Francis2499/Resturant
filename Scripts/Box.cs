using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject PositionToSpawn;

   public void SpawnCookie()
    {
        Debug.Log("Spawning Cookie");
        Instantiate(prefab, PositionToSpawn.transform.position, transform.rotation);
    }
}

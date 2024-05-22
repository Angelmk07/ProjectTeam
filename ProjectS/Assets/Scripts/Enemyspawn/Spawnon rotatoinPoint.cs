using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnonrotatoinPoint : MonoBehaviour
{
    public GameObject prefab; 
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;



    public void SpawnObject()
    {
        float minX = Mathf.Min(pointA.position.x, pointB.position.x, pointC.position.x, pointD.position.x);
        float maxX = Mathf.Max(pointA.position.x, pointB.position.x, pointC.position.x, pointD.position.x);
        float minZ = Mathf.Min(pointA.position.z, pointB.position.z, pointC.position.z, pointD.position.z);
        float maxZ = Mathf.Max(pointA.position.z, pointB.position.z, pointC.position.z, pointD.position.z);

        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
        Instantiate(prefab, spawnPosition, Quaternion.identity);

    }
}

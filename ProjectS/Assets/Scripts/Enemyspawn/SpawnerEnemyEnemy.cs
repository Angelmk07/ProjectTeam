using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerEnemyEnemy : MonoBehaviour
{
    public Transform posForSpwn;
    private SpawnonrotatoinPoint spawnonrotatoin;


    public void OnBecameVisible()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new  WaitForSeconds(6f);
        spawnonrotatoin.SpawnObject();
        Spawn();
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerEnemyEnemy : MonoBehaviour
{
    public Transform posForSpwn;
    [SerializeField] private GameObject prefubSpawnObj;

    float timeToSpawn;

    private void Start()
    {
        timeToSpawn = Time.time;
    }
    private void Update()
    {
        if(Time.time - timeToSpawn > 6)
        {
            Spawn();
            timeToSpawn = Time.time;
        }

    }
    void Spawn()
    {
       GameObject gameObject = ForEnemy.SpawnInBox(prefubSpawnObj);
        
    }
}

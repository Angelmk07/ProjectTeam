using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlCange : MonoBehaviour
{



    [SerializeField] private SpawnEnemy spawn;
    [SerializeField] private TextMeshProUGUI groundEnemyText;


    private int groundEnemyCount;
    private int flyingEnemyCount;



    void Update()
    {
        UpdateEnemyCounts();
        UpdateUIText();
        CheckAndSpawnEnemies();
    }

    void UpdateEnemyCounts()
    {
        groundEnemyCount = GameObject.FindGameObjectsWithTag("GroundEnemy").Length;
        flyingEnemyCount = GameObject.FindGameObjectsWithTag("Flying").Length;
    }

    void UpdateUIText()
    {

        groundEnemyText.text = $"Enemies: {groundEnemyCount + flyingEnemyCount}"  ;

    }

    void CheckAndSpawnEnemies()
    {
        if (groundEnemyCount == 0 && flyingEnemyCount == 0)
        {
            spawn.spawn();
        }
    }
}

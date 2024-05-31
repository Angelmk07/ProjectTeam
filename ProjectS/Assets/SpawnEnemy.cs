using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject shoting;
    [SerializeField] private GameObject little;

    [SerializeField] private GameObject spawner;
    [SerializeField] private GameObject healer;
    [SerializeField] private GameObject DefoltEnemy;
    public void spawn()
    {
        for(int i = 0; i < 3 + LvlPlayer.DefenceLvlOnScreen; i++)
        {
          GameObject DefoltEnemyInstance = ForEnemy.SpawnInBox(DefoltEnemy);
            DefoltEnemyInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar +=LvlPlayer.DefenceLvlOnScreen/3;
            DefoltEnemyInstance.GetComponent<EnemyDamage>().InteractWhithBar = DefoltEnemyInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;


        }
        if (LvlPlayer.DefenceLvlOnScreen % 2 == 0)
        {
            for (int y = 0; y < (int)LvlPlayer.DefenceLvlOnScreen / 2; y++)
            {
                GameObject littleInstance = ForEnemy.SpawnInBox(little);
                littleInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen / 3;
                littleInstance.GetComponent<EnemyDamage>().InteractWhithBar = littleInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
            }
        }
        if (LvlPlayer.DefenceLvlOnScreen % 4 == 0)
        {
            for (int y = 0; y < (int)LvlPlayer.DefenceLvlOnScreen / 4; y++)
            {
                GameObject shotingInstance = ForEnemy.SpawnInBox(shoting);
                shotingInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen / 3;
                shotingInstance.GetComponent<EnemyDamage>().InteractWhithBar = shotingInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
            }
        }
        if (LvlPlayer.DefenceLvlOnScreen % 6 == 0)
        {
            for (int y = 0; y < (int)LvlPlayer.DefenceLvlOnScreen / 5; y++)
            {
                GameObject healerInstance = ForEnemy.SpawnInBox(healer);
                healerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen / 3;
                healerInstance.GetComponent<EnemyDamage>().InteractWhithBar = healerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
            }
        }
        if (LvlPlayer.DefenceLvlOnScreen % 7 == 0)
        {
            for (int y = 0; y < (int)LvlPlayer.DefenceLvlOnScreen / 6; y++)
            {

                GameObject spawnerInstance = ForEnemy.SpawnInBox(spawner);
                spawnerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen / 3;
                spawnerInstance.GetComponent<EnemyDamage>().InteractWhithBar = spawnerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
            }
        }
    }
}

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
        for(int i = 0; i < 3 + LvlPlayer.ClickerLvlOnScreen; i++)
        {
          GameObject DefoltEnemyInstance = ForEnemy.SpawnInBox(DefoltEnemy);
            DefoltEnemyInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar +=LvlPlayer.DefenceLvlOnScreen;
            DefoltEnemyInstance.GetComponent<EnemyDamage>().InteractWhithBar = DefoltEnemyInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
            if (LvlPlayer.DefenceLvlOnScreen % 3 == 0)
            {
                for (int y = 0; y < (int)LvlPlayer.ClickerLvlOnScreen / 3; y++)
                {
                    GameObject littleInstance = ForEnemy.SpawnInBox(shoting);
                    littleInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen;
                    littleInstance.GetComponent<EnemyDamage>().InteractWhithBar = littleInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
                }
            }
            if (LvlPlayer.DefenceLvlOnScreen % 5 == 0)
            {
                for (int y = 0; y <(int)LvlPlayer.ClickerLvlOnScreen/5; y++)
                {
                    GameObject shotingInstance = ForEnemy.SpawnInBox(shoting);
                    shotingInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen;
                    shotingInstance.GetComponent<EnemyDamage>().InteractWhithBar = shotingInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
                }
            }
            if (LvlPlayer.DefenceLvlOnScreen % 7 == 0)
            {
                for (int y = 0; y < (int)LvlPlayer.ClickerLvlOnScreen / 7; y++)
                {
                    GameObject healerInstance = ForEnemy.SpawnInBox(shoting);
                    healerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen;
                    healerInstance.GetComponent<EnemyDamage>().InteractWhithBar = healerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
                }
            }
            if (LvlPlayer.DefenceLvlOnScreen % 10 == 0)
            {
                for (int y = 0; y < (int)LvlPlayer.ClickerLvlOnScreen / 10; y++)
                {
                    
                    GameObject spawnerInstance = ForEnemy.SpawnInBox(shoting);
                    spawnerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar += LvlPlayer.DefenceLvlOnScreen;
                    spawnerInstance.GetComponent<EnemyDamage>().InteractWhithBar = spawnerInstance.GetComponent<EnemyDamage>().InteractWhithMaxBar;
                }
            }

        }
    }
}

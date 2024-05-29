using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlCange : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textMesh;

    bool AddEnemy;
    public void CheckEnemy()
    {
        GameObject[] FlyingEnemys = GameObject.FindGameObjectsWithTag("Flying");
        GameObject[] GrounEnemys = GameObject.FindGameObjectsWithTag("GroundEnemy");
        if (FlyingEnemys.Length == 0 && GrounEnemys.Length == 0)
        {
            LvlPlayer.DefenceLvl += 1;
            AddEnemy = true;
        }
        else
        {
            textMesh.text = $"Осталось {GrounEnemys.Length+FlyingEnemys.Length} противников";
            AddEnemy = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsEnemyOnBrain : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GroundEnemy"||collision.tag =="Flying")
        {
            Destroy(collision);
            InteractWhisPLayerBar.ChangeBar(-EnemyPower.EnemyStrength);
        }
    }
}

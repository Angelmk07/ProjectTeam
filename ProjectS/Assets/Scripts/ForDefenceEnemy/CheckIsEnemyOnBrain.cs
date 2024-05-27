using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsEnemyOnBrain : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroundEnemy"|| collision.gameObject.tag =="Flying")
        {
            InteractWhisPLayerBar.ChangeBar(-EnemyPower.EnemyStrength);
            Destroy(collision.gameObject);

        }
    }
}

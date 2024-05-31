using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsEnemyOnBrain : MonoBehaviour
{
    [SerializeField] private GameObject prefOfBite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroundEnemy"|| collision.gameObject.tag =="Flying")
        {
            InteractWhisPLayerBar.ChangeBar(-EnemyPower.EnemyStrength);
            Destroy(collision.gameObject);
            GameObject Fang = Instantiate(prefOfBite, gameObject.transform);
            Fang.transform.position = Vector3.zero;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsEnemyOnBrain : MonoBehaviour
{
    [SerializeField] private GameObject prefOfBite;
    GameObject canvas;
    private void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("GamePlacesDefence");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroundEnemy"|| collision.gameObject.tag =="Flying")
        {
            InteractWhisPLayerBar.ChangeBar(-EnemyPower.EnemyStrength);
            Destroy(collision.gameObject);
            Instantiate(prefOfBite, gameObject.transform.localPosition,Quaternion.identity,canvas.transform);

        }
    }
}

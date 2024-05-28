using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    //[SerializeField] private ClicksBank Exp;

    EnemyDamage enemyDamage = new EnemyDamage();

    private bool cancelebuy = true;
    private int cost = 500;
    private float explor_pover = 10f;
    [SerializeField] private float radius = 2;


    //public void Start()
    //{
    //    if ((Exp.Clicks - cost) > 0&& cancelebuy)
    //    {


    //        Exp.Clicks -= cost;
    //        cancelebuy = false;
    //    }


    //}
    private void Start()
    {
        Debug.Log("Explre");
  
       Collider2D[] collider2Ds =  Physics2D.OverlapCircleAll(transform.position, radius);
        foreach(Collider2D collider in collider2Ds)
        {

            if (collider.gameObject.tag == "GroundEnemy" || collider.gameObject.tag == "Flying")
            {

                collider.GetComponent<EnemyDamage>().InteractWhithBar -= 0.5f;
            }
            
        }
    }
    //public void ExploreGranade()
    //{
    //    gameObject.GetComponent<EnemyDamage>().EnemyHeatBygranade();
    //    gameObject.GetComponent<EnemyDamage>().InteractWhithBar -= gameObject.GetComponent<EnemyDamage>().InteractWhithBar / 2;

    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("Some");
    //    if (collision.gameObject.tag == "GroundEnemy"|| collision.gameObject.tag == "Flying")
    //    {

    //        collision.GetComponent<EnemyDamage>().InteractWhithBar -= 0.5f;
    //    }
    //}
    
}
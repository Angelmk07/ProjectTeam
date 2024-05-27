using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireG : MonoBehaviour
{
    [SerializeField] private GameObject PrefubBurn;
    int firetime=5;

    IEnumerator Burn(Collider2D collision)
    {


        for (int i = 0; i < firetime; i++)
        {
            collision.GetComponent<EnemyDamage>().InteractWhithBar -= 0.2f;
            yield return new WaitForSecondsRealtime(0.2f);
        }
        
 


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag == "GroundEnemy")
            {
              GameObject newobj =  Instantiate(PrefubBurn,collision.transform);
                newobj.transform.localScale = new Vector3(150, 150, 170);
                StartCoroutine(Burn(collision));
                
            }
        }
    }
}

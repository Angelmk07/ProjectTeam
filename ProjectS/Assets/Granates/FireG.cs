using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireG : MonoBehaviour
{
    [SerializeField] private GameObject PrefubBurn;
    
    int firetime=8*2;

    IEnumerator Burn(Collider2D collision)
    {
        if(collision!=null)
            for (int i = 0; i < firetime; i++)
            {
                if (collision != null)
                    collision.GetComponent<EnemyDamage>().InteractWhithBar -= 0.05f;
                else
                    yield break;
    
                yield return new WaitForSecondsRealtime(0.5f);
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

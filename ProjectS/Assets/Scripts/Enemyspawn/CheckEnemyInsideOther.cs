using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEnemyInsideOther : MonoBehaviour
{



        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag =="GroundEnemy"|| other.tag == "Flying")
                if (gameObject != null)
                {

                    Destroy(gameObject);
                }
            
        }
    
}

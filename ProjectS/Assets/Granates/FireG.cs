using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireG : MonoBehaviour
{
    public void DeploingFire()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("GroundEnemy");
        foreach (GameObject obj in objectsWithTag)
        {
            obj.GetComponent<EnemyDamage>().InteractWhithBar -= 0.1f;
        }
    }
    IEnumerator Burn(GameObject[] objectsWithTag)
    {
        for (int i = 0; i < objectsWithTag.Length; i++)
        {
            foreach (GameObject obj in objectsWithTag)
            {
                obj.GetComponent<EnemyDamage>().InteractWhithBar -= 0.1f;
            }
            yield return new WaitForSeconds(0.5f);
        }


    }

}

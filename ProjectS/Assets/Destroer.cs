using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroer : MonoBehaviour
{
    [SerializeField] private GameObject DestroerPrefub;
    public void OnDeploying()
    {

        Camera.main.transform.DOShakeRotation(5f);
        Camera.main.transform.DOShakePosition(5f);
        Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position, 60);
        foreach (Collider2D collider in collider2Ds)
        {
            if (collider.gameObject.tag == "GroundEnemy" || collider.gameObject.tag == "Flying")
            {
                collider.GetComponent<EnemyDamage>().InteractWhithBar -= 70000f;
            }

        }
    }
}

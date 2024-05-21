using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField]private GameObject prefub;
    [SerializeField] private GameObject BulletPref;
    [SerializeField] private GameObject BrainPos;

    private void Update()
    {
        GameObject gameObject =  ForEnemy.SpawnInBox(prefub);
        GameObject Bullet = Instantiate(BulletPref,gameObject.transform);
        Bullet.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.position-BrainPos.transform.position,ForceMode2D.Impulse);

        
    }
}

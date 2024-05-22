using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField]private GameObject prefub;
    [SerializeField] private GameObject BulletPref;
    [SerializeField] private GameObject BrainPos ;
    float timeWait;
    float SpeedBullet = 0.01f;
    private void Start()
    {
        BrainPos = GameObject.Find("Brain");
        timeWait = Time.time;
    }
    private void Update()
    {
        if(Time.time - timeWait > 5)
        {
            GameObject Bullet = Instantiate(BulletPref, gameObject.transform.position,gameObject.transform.rotation);
            Bullet.GetComponent<Rigidbody2D>().AddForce((BrainPos.transform.position-gameObject.transform.position ) * SpeedBullet*Time.deltaTime, ForceMode2D.Impulse);
            timeWait = Time.time;
        }


        
    }
    public void Spawn()
    {
        GameObject gameObject = ForEnemy.SpawnInBox(prefub);
    }
}

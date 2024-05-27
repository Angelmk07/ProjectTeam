using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public Transform pointup;
    public Transform pointdown;
    public Transform pointleft;
    public Transform pointright;
    public Transform Center;

    public GameObject Prefub;
    float timetoCriateFlyingEnemy;
    private void Start()
    {
        timetoCriateFlyingEnemy = Time.time;
    }
    private void Update()
    {
        if (Time.time - timetoCriateFlyingEnemy >4) 
        {
            CriateFlyingEnemy();
            timetoCriateFlyingEnemy = Time.time;
        }

        
    }
    public void CriateFlyingEnemy()
    {
        transform.rotation *= Quaternion.Euler(0,0,2 * Time.deltaTime);

        if (pointup.parent ==null)
        {
            GameObject gameObjectCriate = Instantiate(Prefub,new Vector2( Random.Range( pointup.position.x,pointleft.position.x), Random.Range(pointup.position.y, pointleft.position.y)), pointup.rotation);
            gameObjectCriate.transform.parent = pointup.transform;
        }
        else if (pointdown.parent == null)
        {
            GameObject gameObjectCriate = Instantiate(Prefub, new Vector2(Random.Range(pointup.position.x, pointright.position.x), Random.Range(pointup.position.y, pointright.position.y)), pointup.rotation);
            gameObjectCriate.transform.parent = pointdown.transform;
        }
        else if (pointleft.parent == null)
        {
            GameObject gameObjectCriate = Instantiate(Prefub, new Vector2(Random.Range(pointdown.position.x, pointright.position.x), Random.Range(pointdown.position.y, pointright.position.y)), pointup.rotation);
            gameObjectCriate.transform.parent = pointleft.transform;
        }
        else if (pointright.parent == null)
        {
            GameObject gameObjectCriate = Instantiate(Prefub, new Vector2(Random.Range(pointdown.position.x, pointleft.position.x), Random.Range(pointdown.position.y, pointleft.position.y)), pointup.rotation);
            gameObjectCriate.transform.parent = pointright.transform;
        }
        else if (gameObject.transform.parent == null)
        {
            GameObject gameObjectCriate = Instantiate(Prefub, new Vector2(Random.Range(pointdown.position.x, pointup.position.x), Random.Range(pointdown.position.y, pointup.position.y)), pointup.rotation);
            gameObjectCriate.transform.parent = gameObject.transform;
        }

    }
}

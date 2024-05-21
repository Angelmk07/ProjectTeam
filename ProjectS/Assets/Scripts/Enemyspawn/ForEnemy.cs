using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEnemy : MonoBehaviour
{
    [SerializeField] private static GameObject leftdownpoint;
    [SerializeField] private static GameObject rightuppoint;
    [SerializeField] private GameObject PrefubOf;
    float X = Mathf.Min(leftdownpoint.transform.position.x, rightuppoint.transform.position.x);
    float Y = Mathf.Min(leftdownpoint.transform.position.y, rightuppoint.transform.position.y);
    public static GameObject SpawnInBox(GameObject Prefub)
    {
       return Instantiate(Prefub, new Vector2(Random.Range(leftdownpoint.transform.position.x,rightuppoint.transform.position.x),
            Random.Range(leftdownpoint.transform.position.y, rightuppoint.transform.position.y)),Quaternion.identity);
    }
}
 
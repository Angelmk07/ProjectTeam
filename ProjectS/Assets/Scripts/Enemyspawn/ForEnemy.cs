using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEnemy : MonoBehaviour
{
    [SerializeField] private static GameObject leftdownpoint;
    [SerializeField] private static GameObject rightuppoint;
    [SerializeField] private GameObject PrefubOf;
    [SerializeField] private static GameObject Canvas;

    //float X = Mathf.Min(leftdownpoint.transform.position.x, rightuppoint.transform.position.x);
    //float Y = Mathf.Min(leftdownpoint.transform.position.y, rightuppoint.transform.position.y);
    private void Start()
    {
        leftdownpoint = GameObject.FindGameObjectWithTag("SpawnPoint1");
        rightuppoint = GameObject.FindGameObjectWithTag("SpawnPoint2");
        Canvas = GameObject.FindGameObjectWithTag("GamePlaces");

    }
    public static GameObject SpawnInBox(GameObject Prefub)
    {
        return Instantiate(Prefub, new Vector2(Random.Range(leftdownpoint.transform.position.x, rightuppoint.transform.position.x),
             Random.Range(leftdownpoint.transform.position.y, rightuppoint.transform.position.y)),Prefub.transform.rotation, Canvas.transform) ;
    }
}
 
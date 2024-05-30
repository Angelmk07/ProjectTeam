using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEnemy : MonoBehaviour
{
    [SerializeField] private static GameObject leftdownpoint;
    [SerializeField] private static GameObject rightuppoint;
    [SerializeField] private static GameObject leftdownpointNotSpawn;
    [SerializeField] private static GameObject rightuppointNotSpawn;
    [SerializeField] private GameObject PrefubOf;
    [SerializeField] private static GameObject Canvas;
    [SerializeField] private static GameObject CanvasDef;
    [SerializeField] private static GameObject CanvasDefence;
    [SerializeField] private static GameObject PrefubChecker;
    internal static bool can_spawn = false;
    static float PosX;
    static float PosY;
    //float X = Mathf.Min(leftdownpoint.transform.position.x, rightuppoint.transform.position.x);
    //float Y = Mathf.Min(leftdownpoint.transform.position.y, rightuppoint.transform.position.y);
    private void Start()
    {
        leftdownpoint = GameObject.FindGameObjectWithTag("SpawnPoint1");
        rightuppoint = GameObject.FindGameObjectWithTag("SpawnPoint2");
        Canvas = GameObject.FindGameObjectWithTag("GamePlaces");
        CanvasDef = GameObject.FindGameObjectWithTag("GamePlacesDefence");
        CanvasDefence = GameObject.FindGameObjectWithTag("GamePlacesDefence");
        rightuppointNotSpawn = GameObject.FindGameObjectWithTag("rightuppointNotSpawn");
        leftdownpointNotSpawn = GameObject.FindGameObjectWithTag("leftdownpointNotSpawn");
        PrefubChecker = GameObject.FindGameObjectWithTag("TryToSpawnChecker");
    }
    public static GameObject SpawnInBox(GameObject Prefub)
    {

        while (!can_spawn)
        {
            IsConflicted();
        }
        can_spawn = false;

        if (GameManager.GameMod==1)
        {

            PosX = Random.Range(leftdownpoint.transform.position.x, rightuppoint.transform.position.x);
            if (PosX> leftdownpointNotSpawn.transform.position.x && PosX < rightuppointNotSpawn.transform.position.x)
            {
                float yMidle = rightuppoint.transform.position.y - rightuppointNotSpawn.transform.position.y;
                float yRange = (Random.Range(leftdownpoint.transform.position.y, rightuppoint.transform.position.y - rightuppointNotSpawn.transform.position.y));
                PosY = yRange * yMidle;

            }
            else
            {
                PosY = Random.Range(leftdownpoint.transform.position.y, rightuppoint.transform.position.y);
            }
            GameObject newObject = Instantiate(Prefub, new Vector2(PosX, PosY), Quaternion.identity, CanvasDef.transform);
             //newObject.transform.localScale = new Vector3(1, 1, 1);
            return newObject;

        }
        else 
        {

            return Instantiate(Prefub, new Vector2(Random.Range(leftdownpoint.transform.position.x, rightuppoint.transform.position.x),
             Random.Range(leftdownpoint.transform.position.y, rightuppoint.transform.position.y)), Prefub.transform.rotation, CanvasDefence.transform);
        }

         static void IsConflicted()
        {
            GameObject gameObjectCheck = Instantiate(PrefubChecker, new Vector2(Random.Range(leftdownpoint.transform.position.x, rightuppoint.transform.position.x),
                  Random.Range(leftdownpoint.transform.position.y, rightuppoint.transform.position.y)), PrefubChecker.transform.rotation, Canvas.transform);
   
            gameObjectCheck.AddComponent<CheckEnemyInsideOther>();
            if(gameObjectCheck != null)
            {
                can_spawn = true;
            }

        }
    }
}
 
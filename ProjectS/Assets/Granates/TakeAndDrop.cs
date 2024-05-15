using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class TakeAndDrop : MonoBehaviour

{
    public Vector3 place;

    internal static bool IsDeploing;
    internal static bool IsOntarget;
    internal bool IsStay;
    EnemyDamage enemyDamage = new EnemyDamage();
    private void Start()
    {
        place = gameObject.transform.position;
    }
    private void Update()
    {

    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0) )
        {
            Vector2 Poscursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(Poscursor.x,Poscursor.y,0);
        }
        else
        {
            //transform.position = place;
        }
        Debug.Log("Moving");
        if (Input.GetMouseButtonUp(0) && IsDeploing)
        {

            enemyDamage.EnemyHeatBygranade();
            enemyDamage.InteractWhithBar -= enemyDamage.InteractWhithBar / 2;
            IsDeploing = false;
        }

    }
    private void OnMouseExit()
    {
        if (!IsOntarget)
        { 
            //transform.position = place;

        }
        
    }


}

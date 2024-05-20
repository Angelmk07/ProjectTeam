using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

<<<<<<< Updated upstream
public class TakeAndDrop : MonoBehaviour, IDragHandler
=======
public class TakeAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler
>>>>>>> Stashed changes

{
    public Vector3 place;

    internal static bool IsDeploing;
    internal static bool IsOntarget;
    internal bool IsStay;
    EnemyDamage enemyDamage = new EnemyDamage();
<<<<<<< Updated upstream
=======
    Explosion Explosion = new Explosion();
>>>>>>> Stashed changes
    private void Start()
    {
        place = gameObject.transform.position;
    }
<<<<<<< Updated upstream
    private void Update()
    {

    }
    //private void OnMouseOver()
    //{

    //    //else
    //    //{
    //    //    //transform.position = place;
    //    //}
    //    //Debug.Log("Moving");
    //    if (Input.GetMouseButtonUp(0) && IsDeploing)
    //    {

    //        enemyDamage.EnemyHeatBygranade();
    //        enemyDamage.InteractWhithBar -= enemyDamage.InteractWhithBar / 2;
    //        IsDeploing = false;
    //    }

    //}
    private void OnMouseExit()
    {
        if (!IsOntarget)
        { 
            //transform.position = place;

        }
        
    }
=======



>>>>>>> Stashed changes

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 Poscursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Poscursor.x, Poscursor.y, 0);
        Vector3 vector = transform.localPosition;
        vector.z = 0;
        transform.localPosition = vector;
<<<<<<< Updated upstream
=======

        if (Input.GetMouseButtonUp(0) && IsDeploing)
        {
            Explosion.ExploreTipe();

            IsDeploing = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!IsOntarget)
        {
            transform.position = place;

        }
    }
    private void OnBecameInvisible()
    {
        transform.position = place;
>>>>>>> Stashed changes
    }
}

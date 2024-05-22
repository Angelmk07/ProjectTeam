using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class TakeAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler

{
    public Vector3 place;

    internal static bool IsDeploingExplosiv;
    internal static bool IsDeploingFire;
    internal static bool IsOntarget;
    internal bool IsStay;
    EnemyDamage enemyDamage = new EnemyDamage();
    FireG FireG = new FireG();
    Explosion ExplosionG = new Explosion();
    internal static GameObject HittenObj;
    private void Start()
    {
        place = gameObject.transform.position;
    }
    private void Update()
    {
        if (IsDeploingExplosiv)
        {

            ExplosionG.ExploreGranade(HittenObj);
            IsDeploingExplosiv = false;
            returnobj();
        }
        if (IsDeploingFire)
        {
            FireG.DeploingFire();
            IsDeploingFire = false;
            returnobj();

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 Poscursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Poscursor.x, Poscursor.y, 0);
        Vector3 vector = transform.localPosition;
        vector.z = 0;
        transform.localPosition = vector;

    }
    public void returnobj()
    {
        transform.position = place;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
            if(!IsOntarget)
            {
                transform.position = place;

            }

        

    }
}

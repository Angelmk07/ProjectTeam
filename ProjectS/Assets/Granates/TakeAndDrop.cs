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
    [SerializeField] private GameObject Granade;
    [SerializeField] private GameObject FireGanade;
    [SerializeField] private GameObject CanvasPlay;
    [SerializeField] private GameObject PlaceForExplosiv;
    [SerializeField] private GameObject PlaceForFire;
    
    //FireG FireG = new FireG();
    //Explosion ExplosionG = new Explosion();

    private void Start()
    {

        if (GameManager.GameMod == 1)
        {
            CanvasPlay = GameObject.FindGameObjectWithTag("GamePlacesDefence");
        }
        else
        {
            CanvasPlay = GameObject.FindGameObjectWithTag("GamePlaces");
        }
    }
    //private void Update()
    //{
    //    if (IsDeploingExplosiv)
    //    {

    //        ExplosionG.ExploreGranade();
    //        IsDeploingExplosiv = false;

    //    }
    //    if (IsDeploingFire)
    //    {
    //        FireG.DeploingFire();
    //        IsDeploingFire = false;


    //    }
    //}

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 Poscursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Poscursor.x, Poscursor.y, 0);
        Vector3 vector = transform.localPosition;
        vector.z = 0;
        transform.localPosition = vector;

    }

    public void OnEndDrag(PointerEventData eventData)
    {


        if(gameObject.name == "ExplosiveGranade")
        {
            Instantiate(Granade, transform.position, Granade.transform.rotation, CanvasPlay.transform);
            transform.position = PlaceForExplosiv.transform.position;
        }
        if (gameObject.name == "Fire")
        {
            
            Instantiate(FireGanade, transform.position, Granade.transform.rotation, CanvasPlay.transform);
            transform.position = PlaceForFire.transform.position;
        }




    }
}

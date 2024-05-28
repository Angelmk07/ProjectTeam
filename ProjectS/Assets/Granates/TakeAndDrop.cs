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
    
    //FireG FireG = new FireG();
    //Explosion ExplosionG = new Explosion();

    private void Start()
    {
        place = gameObject.transform.position;
        if (PlayerPrefs.GetInt("GameMod") == 0)
        {
            CanvasPlay = GameObject.FindGameObjectWithTag("GamePlaces");
        }
        else
        {
            CanvasPlay = GameObject.FindGameObjectWithTag("GamePlacesDefend");
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
        }
        if (gameObject.name == "Fire")
        {
            Instantiate(FireGanade, transform.position, Granade.transform.rotation, CanvasPlay.transform);
        }
        transform.position = place;



    }
}

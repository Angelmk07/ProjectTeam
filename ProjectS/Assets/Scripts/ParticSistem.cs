using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticSistem : MonoBehaviour
{
    [SerializeField] public ParticleSystem ParticleSystem;


    public void onClick()
    {
        ParticleSystem.Emit(1);
    }





}

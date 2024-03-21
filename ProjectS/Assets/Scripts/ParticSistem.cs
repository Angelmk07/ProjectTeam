using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticSistem : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    public void onClick()
    {
        ParticleSystem.Emit(1);
    }
    [SerializeField] public static ParticleSystem particleSystemHeal;
    [SerializeField] public static ParticleSystem particleSystemDebuff;


    private void Start()
    {
        check();
    }
    public static void check()
    {

        if (particleSystemHeal.isEmitting == false)
        {
            particleSystemDebuff.Emit(1);
        }
        check();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticSistem : MonoBehaviour
{
    [SerializeField] public ParticleSystem ParticleSystem;
    [SerializeField] public ParticleSystem particleSystemDebuff;
    IEnumerator Start()
    {
        while (true)
        {

            if (ParticleSystem.particleCount >0)
            {
                particleSystemDebuff.Emit(1);
            }
            yield return new WaitForSeconds(1f);
        }
    }
    public void onClick()
    {
        ParticleSystem.Emit(1);
    }





}

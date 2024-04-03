using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticOfAttack : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemAttack;
    public void onClick()
    {
        _particleSystemAttack.Emit(1);
    }
}

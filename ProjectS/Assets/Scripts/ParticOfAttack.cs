using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticOfAttack : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemAttack;
    [SerializeField] private Slider EnemyBar_S;
    public void onClick()
    {
        _particleSystemAttack.Emit(1);
        if (EnemyBar_S.value < 0.01f)
        {
            _particleSystemAttack.Emit(40);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StanG : MonoBehaviour
{
    bool IsReadyToStan = true;
    public void OnUseStan()
    {

        if (IsReadyToStan)
        {
            StartCoroutine(ReloadStan());
        }
    }

    IEnumerator ReloadStan()
    {
        IsReadyToStan = false;
        Time.timeScale = 0.2f;
        yield return new WaitForSeconds(30f);
        IsReadyToStan = true;
        Time.timeScale = 1f;
    }
}

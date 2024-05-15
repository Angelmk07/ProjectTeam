using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public Transform pointup;
    public Transform pointdown;
    public Transform pointleft;
    public Transform pointright;
    public Transform Rotate;

    public GameObject Prefub;
    void Update()
    {
        Rotate.rotation *= Quaternion.Euler(0,0,2 * Time.deltaTime);

        if (pointup.parent ==null)
        {
            Instantiate(Prefub, pointup.position, pointup.rotation);
        }
        else if (pointdown.parent == null)
        {
            Instantiate(Prefub, pointup.position, pointup.rotation);
        }
        else if (pointleft.parent == null)
        {
            Instantiate(Prefub, pointup.position, pointup.rotation);
        }
        else if (pointright.parent == null)
        {
            Instantiate(Prefub, pointup.position, pointup.rotation);
        }
    }
}

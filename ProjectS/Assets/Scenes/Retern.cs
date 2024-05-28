using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Retern : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        if(GameManager.GameMod == 0)
            SceneManager.LoadScene("Clikcer");
        else
            SceneManager.LoadScene("Defence");
    }


}

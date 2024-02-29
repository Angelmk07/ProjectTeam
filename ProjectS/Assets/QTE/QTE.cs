using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QTE : MonoBehaviour
{
    [SerializeField] private GameObject shouQwe_1;
    [SerializeField] private GameObject shouQwe_2;
    [SerializeField] private GameObject shouQwe_3;

    [SerializeField] private Image TrueQTE_1;
    [SerializeField] private Image TrueQTE_2;
    [SerializeField] private Image TrueQTE_3;
    [SerializeField] private Image healbarcharacter;
    [SerializeField] private Slider EnemyBar_S;

    private readonly int _time = 10;
    //private bool _timeOut = true;
    //private bool _Damage;
    //private bool _NoDamage;
    private bool _Started = false;
    private bool QTE_heat = false;
    private bool complit = false;
    private int _StartedTime = 0;
    public void Update()
    {

        if (_Started == false)
        {

            _StartedTime = (int)(Time.realtimeSinceStartup);
            _Started = true;
            
        }

        
        shouQwe_1.SetActive(true);
        shouQwe_2.SetActive(true);
        shouQwe_3.SetActive(true);

            if (Input.GetKeyDown(KeyCode.S ) && TrueQTE_1.color != Color.green)
                TrueQTE_1.color = Color.green;
            else if (Input.GetKeyDown(KeyCode.S)&& TrueQTE_1.color == Color.green)
                TrueQTE_2.color = Color.green;
            if (Input.GetKey(KeyCode.D)&& TrueQTE_2.color == Color.green)
            {
                        TrueQTE_3.color = Color.green;
                         QTE_heat = true;
                        complit = true;
            }

            int timeElapsed = (int)(Time.realtimeSinceStartup) - _StartedTime;
                if (_time - timeElapsed <= 0||complit)
                {
                    _Started = false;
                    if (QTE_heat)
                    {
                        EnemyBar_S.value -= 0.2f;
                        QTE_heat = false;
                    }
                    else
                    {
                        healbarcharacter.fillAmount -= 0.2f;
                    }
                    complit = false;
                    shouQwe_1.SetActive(false);
                    shouQwe_2.SetActive(false);
                    shouQwe_3.SetActive(false);
                    TrueQTE_1.color = Color.white;
                    TrueQTE_2.color = Color.white;
                    TrueQTE_3.color = Color.white;
                    StartCoroutine(nameof(StartQTE));
                }
            
    }




    IEnumerator StartQTE()
    {
        yield return new WaitForSeconds(4f);

    }
    IEnumerator complitsucses()
    {
        for (int i = 0; i < 4; i--)
        {
            TrueQTE_1.color = Color.white;
            TrueQTE_2.color = Color.white;
            TrueQTE_3.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            
        }
        

    }
    void changecolor(Color color)
    {
        TrueQTE_1.color = Color.white;
        TrueQTE_2.color = Color.white;
        TrueQTE_3.color = Color.white;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddQte : MonoBehaviour
{
    bool Isstart=true;
    [SerializeField] private GameObject _background;
    [SerializeField] private GameObject W;
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject S;
    [SerializeField] private GameObject D;


    GameObject gameobj;
    public List<int> position = new List<int>();
    float timeStart;
    void Update()
    {
        if (Isstart)
        {
            timeStart = Time.time;
            _background.SetActive(true);
            int randomValueNams = Random.Range(3,8);
            for (int i = 0; i < randomValueNams; i++)
            {
                int randomPosition = Random.Range(0,3);
                switch (randomPosition)
                {
                    case 0:
                        gameobj = Instantiate(W);
                        break;
                    case 1:
                        gameobj = Instantiate(A);
                        break;
                    case 2:
                        gameobj = Instantiate(S);
                        break;
                    case 3:
                        gameobj = Instantiate(D);
                        break;
                }
                gameobj.transform.parent = _background.transform;
                position.Add(randomPosition);

            }

            if(Time.time - timeStart > 15)
            {
                Isstart = false;
                //удар
            }
        }
    }
}

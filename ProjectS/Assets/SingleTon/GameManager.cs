using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PoverActivBust _PoverActivBust;
    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return _instance;
        }
    }
    private static GameManager _instance;
    


    static public int GameMod = 1;
    static public float PoverBrainOun = BrainHeats.Pover;
    //static public float AttackPointInBank = AttackMoneyAdd.AttackPointAdd;
    static public float AttackPointOun = AttackMoneyBank.MoneyForTeam;
    //static public float CliksOun = ClicksBank.Clicks;
   // public float PowerOun = _PoverActivBust.stakValue;
    


    private GameManager() { }

}

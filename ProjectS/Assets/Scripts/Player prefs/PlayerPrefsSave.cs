using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPrefsSave : MonoBehaviour
{
    public ClicksBank _ClicksBank;
    public PoverActivBust _PoverActivBust;
    private void Start()
    {
        _ClicksBank = GameObject.Find("BankSystem").GetComponent<ClicksBank>();
        _PoverActivBust = GameObject.Find("PoverBust").GetComponent<PoverActivBust>();
    }
    void Save()
    {
        PlayerPrefs.SetInt("GameMod",0);
        PlayerPrefs.SetFloat("PoverBrainOun", BrainHeats.Pover);
        PlayerPrefs.SetInt("AttackPointOun", AttackMoneyBank.MoneyForTeam);
        PlayerPrefs.SetInt("CliksOun", _ClicksBank.Clicks);
        PlayerPrefs.SetInt("PowerOun", _PoverActivBust.stakValue);
        PlayerPrefs.Save();
    }
    void Load()
    {
        PlayerPrefs.GetInt("GameMod");
        BrainHeats.Pover=PlayerPrefs.GetFloat("PoverBrainOun");
        AttackMoneyBank.MoneyForTeam = PlayerPrefs.GetInt("AttackPointOun");
        _ClicksBank.Clicks = PlayerPrefs.GetInt("CliksOun");
        _PoverActivBust.stakValue = PlayerPrefs.GetInt("PowerOun");

    }

}

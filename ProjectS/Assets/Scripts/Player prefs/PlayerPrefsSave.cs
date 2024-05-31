using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPrefsSave : MonoBehaviour
{
    public ClicksBank _ClicksBank;
    public PoverActivBust _PoverActivBust;
    public AddHealbar _addHealbar;
    [SerializeField] private GameObject Explosiv;
    [SerializeField] private GameObject Stan;
    [SerializeField] private GameObject Fire;
    [SerializeField] private GameObject Destroyer;

    internal void Save()
    {

        if (BuyExplosiv.HaveItem)
            PlayerPrefs.SetInt("ExplosivBought", 1);
        else
            PlayerPrefs.SetInt("ExplosivBought", 0);
        if (BuyFire.HaveItem)
            PlayerPrefs.SetInt("FireBought", 1);
        else
            PlayerPrefs.SetInt("FireBought", 0);
        if (BuyStopTime.HaveItem)
            PlayerPrefs.SetInt("StopTime", 1);
        else
            PlayerPrefs.SetInt("StopTime", 0);


        PlayerPrefs.SetFloat("PoverBrainOun", BrainHeats.Pover);
        PlayerPrefs.SetInt("AttackPointOun", AttackMoneyBank.MoneyForTeam);
        PlayerPrefs.SetInt("CliksOun", _ClicksBank.Clicks);
        PlayerPrefs.SetInt("PowerOunStack", _PoverActivBust.stakValue);
        PlayerPrefs.SetInt("PowerOun", _PoverActivBust.cost);
        if (PasivHeal.IsbuyDo)
            PlayerPrefs.SetInt("PasivBought", 1);
        else
            PlayerPrefs.SetInt("PasivBought", 0);
        PlayerPrefs.SetFloat("EnemyPower",EnemyPower.EnemyStrength);
        PlayerPrefs.SetFloat("TwoKnifse",TwoKnifes.cost);
        PlayerPrefs.SetFloat("TwoKnifse",TwoKnifes.chanse);
        if (_addHealbar.Isbuy)
        {
            PlayerPrefs.SetInt("PasivBought", 1);

        }
        else
        {
            PlayerPrefs.SetInt("PasivBought", 0);

        }

        if (DestroyerBuy.HaveDestroer)
        {
            PlayerPrefs.SetInt("HaveDestroer", 1);

        }
        else
        {
            PlayerPrefs.SetInt("HaveDestroer", 0);

        }

        PlayerPrefs.SetInt("LvlClicker", LvlPlayer.ClickerLvl);
        PlayerPrefs.SetInt("LvlDefence", LvlPlayer.DefenceLvl);
        PlayerPrefs.SetInt("LvlKnife", TwoKnifes.lvl);
        PlayerPrefs.SetInt("BankAttack", AttackMoneyBank.MoneyForTeam);
        PlayerPrefs.SetInt("CostSwoard", SwordAttackBust.cost);


        PlayerPrefs.Save();
    }
    internal void Load()
    {
        if (PlayerPrefs.GetInt("ExplosivBought")==1)
            Explosiv.SetActive(true);
        else
            Explosiv.SetActive(false);

        if (PlayerPrefs.GetInt("FireBought") == 1)
            Fire.SetActive(true);
        else
            Fire.SetActive(false);

        if (PlayerPrefs.GetInt("StopTime") == 1)
            Stan.SetActive(true);
        else
            Stan.SetActive(false);

        if (PlayerPrefs.GetInt("HaveDestroer") ==1)
        {
            Destroyer.SetActive(true);

        }
        else
        {
            Destroyer.SetActive(false);

        }

        BrainHeats.Pover=PlayerPrefs.GetFloat("PoverBrainOun");
        AttackMoneyBank.MoneyForTeam = PlayerPrefs.GetInt("AttackPointOun");
        _ClicksBank.Clicks = PlayerPrefs.GetInt("CliksOun");
        _PoverActivBust.stakValue = PlayerPrefs.GetInt("PowerOunStack");
        _PoverActivBust.cost = PlayerPrefs.GetInt("PowerOun");

        if (PlayerPrefs.GetInt("PasivBought") == 1)
            PasivHeal.IsbuyDo = true;
        else
            PasivHeal.IsbuyDo = false;

        EnemyPower.EnemyStrength = PlayerPrefs.GetFloat("EnemyPower");
        if (PlayerPrefs.GetInt("PasivBought") == 1)
        {

            _addHealbar.Isbuy = true;
            AddHealbar.IsHealHave = true;
        }

        else
        {
            _addHealbar.Isbuy = false;
            AddHealbar.IsHealHave = false;
        }

        TwoKnifes.cost = PlayerPrefs.GetInt("TwoKnifseCost");
        TwoKnifes.chanse = PlayerPrefs.GetInt("TwoKnifseChanse");
        LvlPlayer.ClickerLvl = PlayerPrefs.GetInt("LvlClicker");
        LvlPlayer.DefenceLvl = PlayerPrefs.GetInt("LvlDefence");
        TwoKnifes.lvl = PlayerPrefs.GetInt("LvlKnife");
        AttackMoneyBank.MoneyForTeam = PlayerPrefs.GetInt("BankAttack");
        SwordAttackBust.cost = PlayerPrefs.GetInt("CostSwoard");
        GameManager.GameMod = PlayerPrefs.GetInt("GameMod");
    }

}

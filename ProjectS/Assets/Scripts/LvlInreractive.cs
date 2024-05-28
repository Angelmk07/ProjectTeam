using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlInreractive : MonoBehaviour
{
    public void LvlUp()
    {
        if (GameManager.GameMod == 0)
        {
            if (LvlPlayer.ClickerLvlOnScreen + 1 <= LvlPlayer.ClickerLvl)
            {
                LvlPlayer.ClickerLvlOnScreen += 1;
            }
        }
        else
        {
            if (LvlPlayer.DefenceLvlOnScreen + 1 <= LvlPlayer.DefenceLvl)
            {
                LvlPlayer.DefenceLvlOnScreen += 1;
            }
        }



    }
    public void LvlDown()
    {
        if(GameManager.GameMod == 0)
        {
            if (LvlPlayer.ClickerLvlOnScreen - 1 >= 0)
            {
                LvlPlayer.ClickerLvlOnScreen -= 1;
            }
        }
        else
        {
            if (LvlPlayer.DefenceLvlOnScreen - 1 >= 0)
            {
                LvlPlayer.DefenceLvlOnScreen -= 1;
            }
        }

    }
}

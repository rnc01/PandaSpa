using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyPanda : Panda
{
    private void Awake()
    {
        pandaType = Type.BabyPanda;
        level = 1;
        cost = 100;
        coinEarned = 10;
        coinEarningCycle = 5f;
}

    protected override string GetPandaName()
    {
        return "BabyPanda";
    }
}

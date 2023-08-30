using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PandaData
{
    public int level;
    public int cost;
    public int coinEarned;
    public float coinEarningCycle;

    public PandaData(int _level, int _cost, int _coinEarned, float _coinEarningCycle)
    {
        level = _level;
        cost = _cost;
        coinEarned = _coinEarned;
        coinEarningCycle = _coinEarningCycle;
    }
}

public abstract class Panda : MonoBehaviour
{
    public Type pandaType;
    public int level;
    public int cost;
    public int coinEarned;
    public float coinEarningCycle;
    protected abstract string GetPandaName();

    public enum Type { BabyPanda, AdultPanda, SellerPanda }
    public static PandaData[,] PandaDataList = {
    { new PandaData(1, 100, 20, 5f), new PandaData(1, 100, 20, 5f), new PandaData(1, 100, 20, 5f) }, // babyPanda, level(1, 2, 3)
    { new PandaData(1, 100, 20, 5f), new PandaData(1, 100, 20, 5f), new PandaData(1, 100, 20, 5f) }, // AdultPanda, level(1, 2, 3)
    { new PandaData(1, 100, 20, 5f), new PandaData(1, 100, 20, 5f), new PandaData(1, 100, 20, 5f) }, // SellerPanda, level(1, 2, 3)
    };
}

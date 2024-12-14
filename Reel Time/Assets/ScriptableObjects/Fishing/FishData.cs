using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFishData", menuName = "FishingGame/FishData")]
public class FishData : ScriptableObject
{
    public string fishName;
    public float weightMin;
    public float weightMax;
    public string rarity;
    public float value;
    public float trueWeight;
    
    public void SetTrueWeight(float newWeight)
    {
        trueWeight = newWeight;
    }
}

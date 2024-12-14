using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public List<FishData> fishList;

    void Start()
    {
        foreach (FishData fish in fishList)
        {
            float randomWeight = Random.Range(fish.weightMin, fish.weightMax);
            float roundedWeight = Mathf.Round(randomWeight * 100f) / 100f;
            fish.SetTrueWeight(roundedWeight);       
            Debug.Log("Fish: " + fish.fishName + ", Weight: " + fish.trueWeight + ", Rarity: " + fish.rarity + ", Value: " + fish.value);
        }
    }

    public FishData GetRandomFish()
    {
        int randomIndex = Random.Range(0, fishList.Count);
        return fishList[randomIndex];
    }
}
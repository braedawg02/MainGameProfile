using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FishingSpot : MonoBehaviour
{
    public FishManager fishManager;
    public Collider fishingCollider;
    public UnityEvent onInteract;
    public FloatData playerFishValue;
    public FishData lastCaughtFish; 
    void Start()
    {
        playerFishValue.SetValue(0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsPlayerInFishingCollider()) // Assuming 'E' is the interact key
        {
            onInteract.Invoke();
        }
    }

    bool IsPlayerInFishingCollider()
    {
        // Assuming the player has a tag "Player"
        Collider[] hitColliders = Physics.OverlapBox(fishingCollider.bounds.center, fishingCollider.bounds.extents, fishingCollider.transform.rotation);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Player"))
            {
                return true;
            }
        }
        return false;
    }

    public void AddFishValueToPlayer()
    {
        FishData caughtFish = fishManager.GetRandomFish();
        playerFishValue.updateValue(caughtFish.value);
        lastCaughtFish = caughtFish;
        Debug.Log("Caught a " + caughtFish.fishName + " weighing " + caughtFish.trueWeight + "kg! Value: " + caughtFish.value);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 100;

    private void Start()
    {
        HealthUp powerUp = FindObjectOfType<HealthUp>();
        if (powerUp != null)
        {
            powerUp.OnHealthUp.AddListener(HandleHealthUp);
        }
    }

    private void HandleHealthUp(int healthUpAmount)
    {
        health += healthUpAmount;
        Debug.Log("Health increased by " + healthUpAmount + ". Current health: " + health);
    }
}

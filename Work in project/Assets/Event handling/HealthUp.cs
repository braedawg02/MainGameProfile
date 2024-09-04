using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthUp : MonoBehaviour
{
    [System.Serializable]
    public class HealthUpEvent : UnityEvent<int> { }

    public HealthUpEvent OnHealthUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int healthUpAmount = 20;
            
            OnHealthUp.Invoke((healthUpAmount));

            Destroy(gameObject);
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Healthup : MonoBehaviour
{
    private UnityEvent getHealth;
    // Start is called before the first frame update
    void Start()
    {
        if (getHealth == null)
        {
            getHealth = new UnityEvent();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

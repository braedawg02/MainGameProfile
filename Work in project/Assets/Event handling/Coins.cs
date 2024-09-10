using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Coins : MonoBehaviour
{
    [System.Serializable]
    
    public class CoinEvent : UnityEvent<int> { }
    
    public CoinEvent OnCoin;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int coinAmount = 1;
            
            OnCoin.Invoke((coinAmount));

            Destroy(gameObject);
            
        }
    }

}

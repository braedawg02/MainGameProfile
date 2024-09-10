using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
    
    public void SetValue(float newValue)
    {
        value = newValue;
    }
    
    public void updateValue(float amount)
    {
        value += amount;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void SetValue(Vector3 newValue)
    {
        value = newValue;
    }

    public void UpdateValue(Vector3 amount)
    {
        value += amount;
    }
}

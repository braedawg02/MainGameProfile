using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;
    
    public void UpdateValue(Vector3 NewVector)
    {
        value += NewVector;
    }
    
    public void ReplaceValue(Vector3 NewVector)
    {
        value = NewVector;
    }
    
    public void Displayposition(Transform transform)
    {
        transform.position = value;
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CheckPointData : ScriptableObject
{
    public Vector3 position;
    public bool isActive;

    public void Activate()
    {
        isActive = true;
    }

    public void Deactivate()
    {
        isActive = false;
    }

    public void SetPosition(Vector3 newPosition)
    {
        position = newPosition;
    }
}

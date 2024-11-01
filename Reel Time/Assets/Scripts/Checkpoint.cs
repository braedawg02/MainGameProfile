using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public CheckPointData checkpointData;

    private void Start()
    {
        checkpointData.SetPosition(transform.position);
        Debug.Log("checkpoint set");
    }
}
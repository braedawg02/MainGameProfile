using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.Events;

public class CheckpointManager : MonoBehaviour
{
    public CheckPointData[] checkpoints;
    public UnityEvent onCheckpointActivated;

    private void Start()
    {
        foreach (var checkpoint in checkpoints)
        {
            checkpoint.Deactivate();
            Debug.Log("checkpoint deactivated");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("checkpoint collision");
            var checkpoint = other.gameObject.GetComponent<Checkpoint>();
            if (checkpoint != null)
            {
                ActivateCheckpoint(checkpoint.checkpointData);
                Debug.Log("entering checkpoint event");
            }
        }
    }

    public void ActivateCheckpoint(CheckPointData checkpoint)
    {
        foreach (var cp in checkpoints)
        {
            cp.Deactivate();
        }

        checkpoint.Activate();
        onCheckpointActivated.Invoke();
        Debug.Log("Checkpoint activated");
    }

    public CheckPointData GetActiveCheckpoint()
    {
        foreach (var checkpoint in checkpoints)
        {
            if (checkpoint.isActive)
            {
                return checkpoint;
            }
        }
        return null;
    }
}
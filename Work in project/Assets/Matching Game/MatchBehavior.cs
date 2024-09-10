
using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter
    {
        debug.Log("ID: " + idObj.id);
    }
}

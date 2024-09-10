using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent onMatch, onNoMatch;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
        {
            return;
        }
        var otherID = tempObj.idObj;
        if (idObj == otherID)
        {
            onMatch.Invoke();
        }
        else
        {
            onNoMatch.Invoke();
        }
    }
 
}
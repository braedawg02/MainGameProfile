using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent, repeatUntilFalseEvent;

    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        startEvent.Invoke();
        yield return wfsObj;

        while (counterNum.value > 0)
        {
            Debug.Log("Counter: " + counterNum.value);
            repeatEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;

        }
        Debug.Log("Coroutine End");
        endEvent.Invoke();
        

    }
}

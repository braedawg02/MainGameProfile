
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public UnityEvent disableEvent;
    
    public void compareValues(IntData obj)
    {
        if (value >= obj.value)
        {
        }
        else
        {
            value = obj.value;
        }
    }
    
    public void SetValue(IntData obj)
    {
        value = obj.value;
    }
    
    public  void SetValue(int number)
    {
        value = number;
    }
    
    public void UpdateValue(int number)
    {
        value += number;
    }
    
    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}

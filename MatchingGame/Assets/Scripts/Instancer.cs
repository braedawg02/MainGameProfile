using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num = 0;
    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
    }
    
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }  
    
    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var vector3Data in obj.vector3DList)
        {
            Instantiate(prefab, vector3Data.value, Quaternion.identity);
        }
    }
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate (prefab, obj.vector3DList[num].value, Quaternion.identity);
        num++;
        if (num >= obj.vector3DList.Count)
        {
            num = 0;
        }

    }
    
    public void CreateInstanceListRandom(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count - 1);
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    }
}

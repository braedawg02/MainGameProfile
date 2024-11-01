using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsobj;

    private IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        yield return wfsobj;
        Destroy(gameObject);
        
    }

}

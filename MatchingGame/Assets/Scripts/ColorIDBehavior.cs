using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDDataList ColorIDDataListobj;

    private void Awake()
    {
        idObj = ColorIDDataListobj.currentColor;
    }
}

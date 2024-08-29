using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public Item value;
    
    public void UpdateValue(Item newItem)
    {
        value = newItem;
    }
    
    public void ReplaceValue(Item newItem)
    {
        value = newItem;
    }
    
    public void DisplayImage(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.sprite = value.sprite;
    }
    
    public void DisplayCount(TextMesh text)
    {
        text.text = value.count.ToString();
    }
    
    public void DisplayName(TextMesh text)
    {
        text.text = value.name;
    }

}
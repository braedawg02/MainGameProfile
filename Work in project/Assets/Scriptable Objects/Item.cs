using UnityEngine;

[System.Serializable]
public class Item
{
    public int id;
    public Sprite sprite;
    public int count;
    public string name;

    public Item(int id, Sprite sprite, int count, string name)
    {
        this.id = id;
        this.sprite = sprite;
        this.count = count;
        this.name = name;
    }
}

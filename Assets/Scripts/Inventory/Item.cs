using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

public class Item 
{

    [SerializeField] private int _id;
    [SerializeField] private CreateItem createItem;
    [SerializeField] private Sprite _sprite;

    public void Initialization() 
    {
        _id = Random.Range(0, 3);
        foreach (var item in ItemData.instance.itemXML.items)
        {
            if (item.id == _id)
            {
                SetItem(item);
            }
        }
    }

    public void SetItem(CreateItem _item) 
    {
        createItem = _item;
        _sprite = Resources.Load<Sprite>("Inventory/PNG/Transperent/" +  _item.name);
    }

    public Sprite GetSprite() => _sprite;

}




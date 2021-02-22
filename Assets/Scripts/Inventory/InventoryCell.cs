using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCell : MonoBehaviour
{

    [SerializeField] private Item _item;

    public void InitializationItem(Item __item) 
    {
        _item = __item;
        GetComponent<Image>().sprite = __item.GetSprite();
    }

}

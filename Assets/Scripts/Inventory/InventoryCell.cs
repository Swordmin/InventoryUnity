using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryCell : MonoBehaviour
{

    [SerializeField] private Item _item;
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private Image _imageItem;
    [SerializeField] private TextMeshProUGUI _speshName;

    public void InitializationItem(Item __item) 
    {
        _item = __item;
        GetComponent<Image>().sprite = __item.GetSprite();
    }

    public void ViewItem() 
    {
        _nameText.text = _item.GetName();
        _speshName.text = _item.GetSpesh();
        _imageItem.sprite = _item.GetSprite();
    }

}

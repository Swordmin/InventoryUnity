using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFill : MonoBehaviour
{

    [SerializeField] private List<InventoryCell> _cells = new List<InventoryCell>();


    private void Start() 
    {
        foreach(var cell in _cells) 
        {
            Item item = new Item();
            item.Initialization();
            cell.InitializationItem(item);
        }
    }

}

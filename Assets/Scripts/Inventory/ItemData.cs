using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    public static ItemData instance;
    private TextAsset asset;
    public ItemXML itemXML;

    private void Awake()
    {
        instance = this;
        asset = Resources.Load<TextAsset>("XML/ItemDatabase");
        itemXML = ItemXML.Load(asset);
    }
}

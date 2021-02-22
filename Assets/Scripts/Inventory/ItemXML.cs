using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("creatures")]
[System.Serializable]
public class ItemXML
{
    [XmlElement("creature")]
    public CreateItem[] items;

    public static ItemXML Load(TextAsset _xmlFile)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemXML));
        StringReader reader = new StringReader(_xmlFile.text);
        ItemXML createItem = serializer.Deserialize(reader) as ItemXML;
        return createItem;
    }
}

[System.Serializable]
public class CreateItem
{

    [XmlAttribute("id")]
    public int id;

    [XmlAttribute("name")]
    public string name;

}

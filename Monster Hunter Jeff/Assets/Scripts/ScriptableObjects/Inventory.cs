using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject {

    public Item currentitem;
    public List<Item> items = new List<Item>();
    public int numberOfKeys;

}

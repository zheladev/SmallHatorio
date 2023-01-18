using System;
using System.Collections.Generic;

public class ItemDB
{
    private static ItemDB instance = null;
    Dictionary<int, Item> items;

    private ItemDB()
    {
        items = new Dictionary<int, Item>()
        {
            [0] = new Item { Id=1, ItemName="Not Found", TexturePath="res://img/error.png"},
            [1] = new Item { Id=1, ItemName="Copper Ore", TexturePath="res://img/ore_0.png"},
            [2] = new Item { Id=2, ItemName="Leaf", TexturePath="res://img/plant_0.png"}
        };
    }

    public Item GetItem(int id)
    {
        Item _item = items.ContainsKey(id) ? items[id] : items[0];
        return _item;
    }

    //this is not thread safe
    public ItemDB Instance() 
    {
        if (instance == null)
        {
            instance = new ItemDB();
        }

        return instance;
    }


}
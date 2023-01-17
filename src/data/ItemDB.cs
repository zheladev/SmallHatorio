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
            [0] = new Item { Id=0, ItemName="Copper Ore", TexturePath="res://img/ore_0.png"},
            [1] = new Item { Id=1, ItemName="Leaf", TexturePath="res://img/plant_0.png"}
        };
    }

    public ItemDB Instance() 
    {
        if (instance == null)
        {
            instance = new ItemDB();
        }

        return instance;
    }


}
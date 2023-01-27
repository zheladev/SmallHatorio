using Godot;
using System;

public class GlobalVars : Node
{
    public ItemDB ItemDB;



    //UI FLAGS
    public Boolean IsMouseItemSpawnerActive = false; //used in Button.cs, MouseItemSpawner.cs
    public override void _Ready()
    {
        ItemDB = ItemDB.Instance();
    }
}

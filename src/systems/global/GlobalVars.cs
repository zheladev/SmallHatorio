using Godot;
using System;

public class GlobalVars : Node
{
    public ItemDB ItemDB;
    public override void _Ready()
    {
        ItemDB = ItemDB.Instance();
    }
}

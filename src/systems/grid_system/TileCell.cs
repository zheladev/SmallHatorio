using Godot;
using System;

public class TileCell : Node
{

    Sprite TileSprite;
    public bool IsOccupied;

    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        TileSprite = GetNode<Sprite>("TileSprite");
        IsOccupied = false;
    }
}

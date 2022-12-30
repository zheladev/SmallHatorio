using Godot;
using System;

public class TileCell : Node2D
{

    enum PlotTypes
    {
        Ground = 0,
        Wall = 1,
        Hole = 2,
    }

    Sprite TileSprite;
    public bool IsOccupied;

    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        //TODO: load sprite dynamically based on cell type
        TileSprite = GetNode<Sprite>("TileSprite");
        IsOccupied = false;
    }
}

using Godot;
using System;
using System.Collections.Generic;

public class TileGrid : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    //(x, y)
    public int GridX, GridY;
    private PackedScene TileCellScene;
    public List<List<TileCell>> TileCells;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _InitValues();

        for (int x = 0; x < GridX; x++)
        {
            List<TileCell> _gridRow = new List<TileCell>();
            TileCells.Add(_gridRow);
            for (int y = 0; y < GridY; y++)
            {
                TileCell _cell = TileCellScene.Instance<TileCell>();
                AddChild(_cell);
                TileCells[x].Add(_cell);
            }
        }
        _DrawPlots();
    }

    private void _DrawPlots()
    {
        int _plotPxSize = 64;
        //add horizontal offset of half the sprite size if even number of columns to center grid.
        int _defaultXOffset = GridX % 2 == 0 ? _plotPxSize/2 : 0; 
        int _defaultYOffset = GridY % 2 == 0 ? _plotPxSize/2 : 0;
        //where to start drawing tiles from left to right.
        int _minXOffset = GridX * _plotPxSize / 2 * -1;
        int _minYOffset = GridY * _plotPxSize / 2 * -1;

        for (int i = 0; i < GridX; i++) 
        {
            int _posX = _minXOffset + _plotPxSize * i + _defaultXOffset;
            
            for (int j = 0; j < GridY; j++)
            {
                int _posY = _minXOffset + _plotPxSize * GridY - _plotPxSize * j - _defaultYOffset;
                Vector2 _pos = new Vector2(_posX, _posY);
                TileCells[i][j].Position = _pos;
            }
        }
    }

    private void _InitValues()
    {
        TileCellScene = ResourceLoader.Load<PackedScene>("res://src/systems/grid_system/TileCell.tscn");
        TileCells = new List<List<TileCell>>();
    }
}
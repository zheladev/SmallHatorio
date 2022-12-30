using Godot;
using System;

public class Main : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    GlobalVars g;
    EventSystem es;

    public Vector2 ScreenCenter;
    private TileGrid TileGrid;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _InitValues();
        TileGrid.Position = ScreenCenter;
    }

    private void _InitValues()
    {
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
        TileGrid = GetNode<TileGrid>("TileGrid");
        Vector2 _screen = GetViewportRect().Size;
        ScreenCenter = _screen / 2;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//
//  }
}
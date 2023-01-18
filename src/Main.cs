using Godot;
using System;

public class Main : Node2D
{
    GlobalVars g;
    EventSystem es;

    public Vector2 ScreenCenter;
    //private TileMap TileMap;
    //TileMap = GetNode<TileMap>("TileMap");
    private Node2D GameWorld;
    public override void _Ready()
    {
        _InitValues();
        _Test();
    }

    private void _InitValues()
    {
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
        GameWorld = GetNode<Node2D>("GameWorld");
        Vector2 _screen = GetViewportRect().Size;
        ScreenCenter = _screen / 2;
    }

    private void _Test()
    {
        PackedScene itemScene = ResourceLoader.Load<PackedScene>("res://src/entities/item/ItemEntity.tscn");
    
        for (int i = 0; i < 2000; i++)
        {

            ItemEntity leaf = itemScene.Instance<ItemEntity>();
            GameWorld.AddChild(leaf);
            leaf.Position = new Vector2(-32 * 9 + 32 * (i % 19),-32 * 9 + 32 * (i % 19));
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//
//  }
}
using Godot;
using System;

public class Item : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    public Sprite ItemSprite;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    private void _InitValues()
    {
        //TODO: load sprite dynamically based on cell type
        ItemSprite = GetNode<Sprite>("ItemSprite");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
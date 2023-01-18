using Godot;
using System;

public class ItemEntity : Node2D
{
    public Item Item;
    public Sprite ItemSprite;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _InitValues();
    }

    public void SetItem(Item i)
    {
        Item = i;
    }

    private void _LoadTexture()
    {
        string _textureString = Item != null ? Item.TexturePath : "error.png";
        Texture _texture = ResourceLoader.Load<Texture>($"res://img/{_textureString}");
        ItemSprite.Texture = _texture;
    }

    private void _InitValues()
    {
        ItemSprite = GetNode<Sprite>("ItemSprite");
        _LoadTexture();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}

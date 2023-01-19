using Godot;

public class ConveyorMechanism : Node2D
{
    private Sprite Sprite;
    private Area2D ConveyorBounds;

    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        Sprite = GetNode<Sprite>("Sprite");
        ConveyorBounds = GetNode<Area2D>("ConveyorBounds");
        Sprite.Texture = ResourceLoader.Load<Texture>("res://img/mechanism/belt_0.png");
    }

    public override void _Process(float delta)
    {
        //move items
    }
}
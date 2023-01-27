using Godot;

public class ConveyorMechanism : Area2D
{
    private Sprite Sprite;

    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        Sprite = GetNode<Sprite>("Sprite");
        Sprite.Texture = ResourceLoader.Load<Texture>("res://img/mechanism/belt_0.png");
    }

    public override void _Process(float delta)
    {
        //move items
    }
}
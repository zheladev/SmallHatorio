using Godot;
using System;

public class MouseItemSpawner : Node2D
{
    GlobalVars g;
    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        g = GetNode<GlobalVars>("/root/GlobalVars");
    }


    public override void _Process(float delta)
    {
        if (Input.IsActionJustPressed("ui_cancel"))
        {
            g.IsMouseItemSpawnerActive = false;
            QueueFree();
        }

        Position = GetGlobalMousePosition();
    }
}

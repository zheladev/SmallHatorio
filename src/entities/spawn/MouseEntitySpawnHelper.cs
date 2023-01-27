using Godot;
using System;

public class MouseEntitySpawnHelper : Node2D
{
    GlobalVars g;
    EventSystem es;
    public override void _Ready()
    {
        _InitValues();
    }

    public override void _Process(float delta)
    {
        _ProcessInputs(delta);
        Position = GetGlobalMousePosition();
    }

    private void _InitValues()
    {
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
    }

    private void _ProcessInputs(float delta)
    {
        if (Input.IsActionJustPressed("ui_cancel"))
        {
            g.IsMouseItemSpawnerActive = false;
            QueueFree();
        }

        if (Input.IsActionJustPressed("left_mouse_click"))
        {
            es.EmitEvent(EventSystem.E_NAMES.SpawnBuilding, Position);
        }
    }
}

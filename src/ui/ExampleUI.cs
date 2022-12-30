using System;
using Godot;

public class ExampleEvent : Container
{
    GlobalVars g;
    EventSystem es;
    public override void _Ready()
    {
        _InitValues();
        _ConnectEvents();
    }

    private void _ConnectEvents()
    {
        es.Connect(nameof(EventSystem.E_NAMES.ExampleEvent), this, nameof(ToggleExample));
    }

    private void _InitValues()
    {
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
    }

    public void OnClicked(InputEvent e)
    {
        if (e is InputEventMouseButton && e.IsPressed())
        {
            es.EmitEvent(EventSystem.E_NAMES.ExampleEvent);
        }
    }

    public void ToggleExample()
    {
        g.Example = !g.Example;
        GD.Print(g.Example);
    }
}

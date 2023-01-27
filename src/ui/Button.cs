using Godot;
using System;

public class Button : Godot.Button
{
    GlobalVars g;
    EventSystem es;
    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
    }

    public void OnClicked()
    {
        if (!g.IsMouseItemSpawnerActive)
        {
            g.IsMouseItemSpawnerActive = true;
            es.EmitEvent(EventSystem.E_NAMES.SpawnMouseEntitySpawnHelper);
        }
    }
}

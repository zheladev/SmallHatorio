using Godot;
using System;

public class Button : Godot.Button
{
    GlobalVars g;
    
    [Export]
    Control GUINode;

    [Export]
    PackedScene MouseItemSpawnerScene;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _InitValues();
    }

    private void _InitValues()
    {
        if (GUINode == null)
        {
            GUINode = GetOwner<Control>();
        }

        MouseItemSpawnerScene = ResourceLoader.Load<PackedScene>("res://src/ui/MouseItemSpawner.tscn");
        g = GetNode<GlobalVars>("/root/GlobalVars");
    }

    public void OnClicked()
    {
        if (!g.IsMouseItemSpawnerActive)
        {
            g.IsMouseItemSpawnerActive = true;
            MouseItemSpawner mis = MouseItemSpawnerScene.Instance<MouseItemSpawner>();
            GUINode.AddChild(mis);
        }
    }
}

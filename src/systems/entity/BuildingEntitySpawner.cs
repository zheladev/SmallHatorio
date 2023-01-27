using Godot;
using System;

public class BuildingEntitySpawner : Node2D
{
    GlobalVars g;
    EventSystem es;

    [Export]
    Node2D GameWorld;
    public override void _Ready()
    {
        _InitValues();
        _ConnectEvents();
    }

    private void _ConnectEvents()
    {
		// Defines behavior for WaterCanToggled signal in EventSystem
		es.Connect(nameof(EventSystem.E_NAMES.SpawnBuilding), this, nameof(SpawnBuilding));
    }

    private void _InitValues()
    {
        if (GameWorld == null)
        {
            GameWorld = GetParent<Node2D>();
        }
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
    }

    public void SpawnBuilding(Vector2 spawnPosition) //pass building info
    {
        GD.Print("Spawn building"); 
        PackedScene beltScene = ResourceLoader.Load<PackedScene>("res://src/entities/mechanism/ConveyorMechanism.tscn");
        //String template = $"res://src/entities/mechanism/{}.tcsn";
        Node2D belt = beltScene.Instance<Node2D>();
        belt.Position = spawnPosition;
        
        AddChild(belt);

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}

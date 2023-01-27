using Godot;
using System;

public class EntitySpawner : Node2D
{
    GlobalVars g;
    EventSystem es;
    GridSystem gs;

    [Export]
    Node2D GameWorld;

    PackedScene MouseEntitySpawnHelperScene;
    public override void _Ready()
    {
        _InitValues();
        _ConnectEvents();
    }

    private void _ConnectEvents()
    {
		es.Connect(nameof(EventSystem.E_NAMES.SpawnBuilding), this, nameof(SpawnBuilding));
        es.Connect(nameof(EventSystem.E_NAMES.SpawnMouseEntitySpawnHelper), this, nameof(SpawnMouseEntitySpawnHelper));
    }

    private void _InitValues()
    {
        if (GameWorld == null)
        {
            GameWorld = GetParent<Node2D>();
        }
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
        gs = GetNode<GridSystem>("/root/GridSystem");
    }

    public void SpawnBuilding(Vector2 spawnPosition) //pass building info
    {
        //TODO: refactor method to spawn any type of building
        PackedScene beltScene = ResourceLoader.Load<PackedScene>("res://src/entities/mechanism/ConveyorMechanism.tscn");
        Node2D belt = beltScene.Instance<Node2D>();
        belt.Position = gs.GetCellCenterFromRealPosition(spawnPosition);
        AddChild(belt);
    }

    public void SpawnMouseEntitySpawnHelper()
    {   
        GD.Print("lol");
        MouseEntitySpawnHelperScene = ResourceLoader.Load<PackedScene>("res://src/entities/spawn/MouseEntitySpawnHelper.tscn");
        MouseEntitySpawnHelper mis = MouseEntitySpawnHelperScene.Instance<MouseEntitySpawnHelper>();
        AddChild(mis);
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}

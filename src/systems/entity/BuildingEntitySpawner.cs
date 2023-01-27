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
            throw new MissingMemberException();
        }
        g = GetNode<GlobalVars>("/root/GlobalVars");
        es = GetNode<EventSystem>("/root/EventSystem");
    }

    public void SpawnBuilding() //pass building info
    {
        GD.Print("Spawn building");
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}

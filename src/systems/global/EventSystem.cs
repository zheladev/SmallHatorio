using Godot;
using System;
using System.Collections.Generic;

public class EventSystem : Node2D
{
    public enum E_NAMES 
    {
        SpawnMouseEntitySpawnHelper,
        SpawnBuilding, //name is relevant, has to match a delegate.
    }

    public E_NAMES EVENT_NAMES { get; private set; }

    [Signal]
    public delegate void SpawnBuilding();

    [Signal]
    public delegate void SpawnMouseEntitySpawnHelper();

    public void EmitEvent(E_NAMES e, params object[] args)
    {
        string sig = "";
        switch (e) //TODO: remove need for switch
        {
            case E_NAMES.SpawnBuilding: 
                sig = nameof(SpawnBuilding);
                break;
            case E_NAMES.SpawnMouseEntitySpawnHelper:
                sig = nameof(SpawnMouseEntitySpawnHelper);
                break;
            default:
                return;
        }
        GD.Print(sig);
        EmitSignal(sig, args);
    }
}

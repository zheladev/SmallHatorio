using Godot;
using System;
using System.Collections.Generic;

public class EventSystem : Node2D
{
    public enum E_NAMES 
    {
        SpawnBuilding, //name is relevant, has to match a delegate.
    }

    public E_NAMES EVENT_NAMES { get; private set; }

    [Signal]
    public delegate void SpawnBuilding();

    public void EmitEvent(E_NAMES e, params object[] args)
    {
        string sig = "";
        switch (e)
        {
            case E_NAMES.SpawnBuilding: 
                sig = nameof(SpawnBuilding);
                break;
            default:
                return;
        }
        EmitSignal(sig, args);
    }
}

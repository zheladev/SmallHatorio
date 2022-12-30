#if TOOLS
using Godot;
using System;

[Tool]
public class StateAwareNode2D : EditorPlugin
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    public override void _EnterTree()
    {
        
        // Initialization of the plugin goes here.
    }
    
    public override void _ExitTree()
    {
        // Clean-up of the plugin goes here.
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
#endif
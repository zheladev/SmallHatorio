using Godot;
using System;

public class GameCamera2D : Camera2D
{
    [Export]
    public Vector2 ZoomAmount = new Vector2(0.2f, 0.2f);
    public Boolean IsMouseDraggingActive = false;

    [Export]
    public float CameraDragSpeedFactor = 1.5f;
    private Vector2 _initialMousePosition;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        _HandleInput(delta);
    }

    private void _HandleInput(float delta)
    {
        if (Input.IsActionJustPressed("camera_drag"))
        {
            IsMouseDraggingActive = true;
            _initialMousePosition = GetViewport().GetMousePosition();
        }

        if (Input.IsActionPressed("camera_drag"))
        {
            Vector2 mousePos = GetViewport().GetMousePosition();
            Vector2 mov = _initialMousePosition - mousePos;
            _initialMousePosition = mousePos;
            Position += mov * CameraDragSpeedFactor;
        }

        if (Input.IsActionJustReleased("camera_drag"))
        {
            IsMouseDraggingActive = false;
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}

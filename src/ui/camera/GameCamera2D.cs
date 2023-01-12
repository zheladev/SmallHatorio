using Godot;
using System;

public class GameCamera2D : Camera2D
{
    [Export]
    public Vector2 ZoomAmount = new Vector2(0.1f, 0.1f);
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
        _HandleCameraDrag();

        _HandleCameraKeyboardMovement(delta);

        _HandleCameraZoom(delta);
    }

    private void _HandleCameraKeyboardMovement(float delta)
    {
        throw new NotImplementedException();
    }

    private void _HandleCameraZoom(float delta)
    {
        //mousewheel only trigger IsActionJustReleased.
        if (Input.IsActionJustReleased("camera_zoom_in"))
        {
            Zoom -= ZoomAmount * 1.5f;
        }

        if (Input.IsActionJustReleased("camera_zoom_out"))
        {
            Zoom += ZoomAmount * 1.5f;
        }

        if (Input.IsActionPressed("camera_zoom_in"))
        {
            Zoom -= ZoomAmount;
        }

        if (Input.IsActionPressed("camera_zoom_out"))
        {
            Zoom += ZoomAmount;
        }
    }

    private void _HandleCameraDrag()
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
            //TODO: take zoom level into account when calculating speed
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

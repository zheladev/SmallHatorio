using Godot;

public class GridSystem : Resource
{
    [Export]
    public Vector2 GridSize = new Vector2(200, 200);
    
    public Vector2 CellSize = new Vector2(64, 64);

    //get cell center position, get cell based on position, get 

    public Vector2 GetCellCenter(Vector2 cell)
    {
        //x, y * px size + offset -> px position of the center of a given cell
        return new Vector2(cell.x * CellSize.x + CellSize.x / 2, cell.y * CellSize.y + CellSize.y / 2);
    }

    public Vector2 GetCellCenterFromRealPosition(Vector2 position)
    {
        return GetCellCenter(GetCellFromRealPosition(position));
    }

    public Vector2 GetCellFromRealPosition(Vector2 position)
    {
        //[0, CellSize.x)              -> (0, y)
        //[CellSize.x, CellSize.x * 2) -> (1, y)
        int _posX = Mathf.FloorToInt(position.x/CellSize.x);
        int _posY = Mathf.FloorToInt(position.y/CellSize.y);
        return new Vector2 (_posX, _posY);
    }
}
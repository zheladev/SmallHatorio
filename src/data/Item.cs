public class Item
{
    private int _id;
    private string _itemName;
    private string _texturePath;
    public string TexturePath { get => _texturePath; set => _texturePath = value; }
    public string ItemName { get => _itemName; set => _itemName = value; }
    public int Id { get => _id; set => _id = value; }

    
}
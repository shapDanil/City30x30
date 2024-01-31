using UnityEngine;

public class GridGenerator: MonoBehaviour
{
    [SerializeField] private Vector2Int _sizeGrid;
    [SerializeField] private Cell _cell;
    [SerializeField, Tooltip("Отступы между клетками по горизонтали и вертикали")] private Vector2 _offset;
    [SerializeField] private Transform _parent;
    [ContextMenu(nameof(GridGenerated))]
    private void GridGenerated()
    {
        Vector3 cellSize = _cell.GetComponent<MeshRenderer>().bounds.size;

        for(int x = 0; x < _sizeGrid.x; x++)
            for (int y = 0; y < _sizeGrid.y; y++)
            {
                Vector3 position = new Vector3(x * (cellSize.x + _offset.x) , 0, y * (cellSize.z + _offset.y));
                var cell = Instantiate(_cell, position, Quaternion.Euler(90,0,0), _parent);
                cell.name = $"Cell({x},{y})";
            }
    }
    
}

using UnityEngine;
using UnityEngine.UI;

public enum CellState
{
    None,
    Friendly,
    Enemy,
    Free,
    OutOfBounds
}

public class Board : MonoBehaviour {

	public GameObject cellPrefab;

	[HideInInspector]
	public Cell[,] allCells = new Cell[8, 8];

	public void Create()
    {
		for(int y = 0; y < 8; y++)
        {
			for(int x = 0; x < 8; x++)
            {
                GameObject newCell = Instantiate(cellPrefab, transform);
                RectTransform rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((x * 100) + 50, (y * 100) + 50);

                allCells[x, y] = newCell.GetComponent<Cell>();
                allCells[x, y].Setup(new Vector2Int(x, y), this);
            }
        }

        for(int x  =0; x  <8; x += 2)
        {
            for(int y = 0; y < 8; y++)
            {
                int offset = (y % 2 != 0) ? 0 : 1;
                int final = x + offset;

                allCells[final, y].GetComponent<Image>().color = new Color32(230, 220, 187, 255);
            }
        }
    }

    public CellState Validation(int targetX, int targetY, Base checking)
    {
        if ((targetX < 0 || targetX > 7) || (targetY < 0 || targetY > 7))
            return CellState.OutOfBounds;

        Cell targetCell = allCells[targetX, targetY];

        if(targetCell.currentPiece != null)
        {
            if (checking.color == targetCell.currentPiece.color)
                return CellState.Friendly;
            else if (checking.color != targetCell.currentPiece.color)
                return CellState.Enemy;
        }

        return CellState.Free;
    }
}

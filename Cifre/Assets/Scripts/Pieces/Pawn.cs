using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Base
{
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 1;
        movement = new Vector3Int(0, 1, 0);
    }

    private void CreatePath()
    {
        int x = currentCell.boardPosition.x;
        int y = currentCell.boardPosition.y;

        Matching(x, y + 1);
        Matching(x, y - 1);
    }

    private void Matching(int x, int y)
    {
        CellState cellState = CellState.None;
        cellState = currentCell.board.Validation(x, y, this);
        if (cellState != CellState.Friendly && cellState != CellState.OutOfBounds)
            cells.Add(currentCell.board.allCells[x, y]);
    }

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }

    public override void Move()
    {
        currentCell = targetCell;
        base.Move();

    }
}

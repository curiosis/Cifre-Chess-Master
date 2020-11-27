using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Base {
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 2;
    }

    private void CreatePath()
    {
        int x = currentCell.boardPosition.x;
        int y = currentCell.boardPosition.y;

        Matching(x - 2, y);
        Matching(x + 2, y);

        Matching(x, y + 2);
        Matching(x, y - 2);
    }

    protected override void CheckingPath()
    {
        CreatePath();
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
}
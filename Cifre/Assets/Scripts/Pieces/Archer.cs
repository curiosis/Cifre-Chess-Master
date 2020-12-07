﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Archer : Base {
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 2;
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Archer");

    }

    private void CreatePath(int flip)
    {
        int x = currentCell.boardPosition.x;
        int y = currentCell.boardPosition.y;

        Matching(x, y + (2 * flip));
        Matching(x, y + (1 * flip));
        Matching(x + (2 * flip), y);
        Matching(x + (1 * flip), y);
    }

    protected override void CheckingPath()
    {
        CreatePath(1);
        CreatePath(-1);
    }

    private void Matching(int x, int y)
    {
        CellState cellState = currentCell.board.Validation(x, y, this);
        if (cellState != CellState.Friendly && cellState != CellState.OutOfBounds)
            cells.Add(currentCell.board.allCells[x, y]);
    }

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Base : EventTrigger {

	public Cell originalCell = null, currentCell = null;
	protected RectTransform rectTransform = null;
	protected PieceManager pieceManager;
	public Color color = Color.clear;
	protected Sprite sprite = null;

	protected Vector3Int movement = Vector3Int.one;
	protected List<Cell> cells = new List<Cell>();

	protected Cell targetCell = null;

	protected int val = 0;

	public virtual void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
		pieceManager = NewPieceManager;
		color = teamColor;
		GetComponent<Image>().color = spriteColor;
		rectTransform = GetComponent<RectTransform>();
    }

	public void Place(Cell newCell)
    {
		currentCell = newCell;
		originalCell = newCell;
		currentCell.currentPiece = this;
		transform.position = newCell.transform.position;
		gameObject.SetActive(true);
    }

	private void CreatePath(int xD, int yD, int movement)
    {
		int x = currentCell.boardPosition.x;
		int y = currentCell.boardPosition.y;

		for(int i=1; i<=movement; i++)
        {
			x += xD;
			y += yD;
            CellState cellState = currentCell.board.Validation(x, y, this);

            if (cellState == CellState.Enemy)
            {
				cells.Add(currentCell.board.allCells[x, y]);
				break;
			}

			if (cellState != CellState.Free)
				break;

			try
			{
				cells.Add(currentCell.board.allCells[x, y]);
			}
			catch { };
		}
    }

	protected virtual void CheckingPath()
    {
		CreatePath(1, 0, movement.x);
		CreatePath(-1, 0, movement.x);

		CreatePath(0, 1, movement.y);
		CreatePath(0, -1, movement.y);

		CreatePath(1, 1, movement.z);
		CreatePath(-1, 1, movement.z);

		CreatePath(-1, -1, movement.z);
		CreatePath(1, -1, movement.z);
	}

	protected void ShowCells()
    {
		foreach (Cell cell in cells)
			cell.outline.enabled = true;
    }

	protected void ClearCells()
    {
		foreach (Cell cell in cells)
			cell.outline.enabled = false;

		cells.Clear();
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
		CheckingPath();
		ShowCells();
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
		transform.position += (Vector3)eventData.delta;

		foreach(Cell cell in cells)
        {
			if(RectTransformUtility.RectangleContainsScreenPoint(cell.rectTransform, Input.mousePosition))
            {
				targetCell = cell;
				break;
            }
			targetCell = null;
        }
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
		ClearCells();
        if (!targetCell)
        {
			transform.position = currentCell.gameObject.transform.position;
			return;
        }
		Move();
		SoundManager.PlaySound("down");
		pieceManager.SwitchSide(color);
    }

	public virtual void Kill()
    {
		currentCell.currentPiece = null;
		SoundManager.PlaySound("kill");
		if (color == Color.black)
			PieceManager.blackPieceVal--;
		else if (color == Color.white)
			PieceManager.whitePieceVal--;
		gameObject.SetActive(false);

    }

	public virtual void Move()
    {
		targetCell.Remove();
		currentCell.currentPiece = null;
		currentCell = targetCell;
		currentCell.currentPiece = this;
		transform.position = currentCell.transform.position;
		targetCell = null;
    }
}

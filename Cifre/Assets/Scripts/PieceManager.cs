using System;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour {

	public GameObject piecePrefab;
	public bool kingAlive = true;

	private List<Base> whitePieces = null;
	private List<Base> blackPieces = null;
	private string[] pieceOrder = new string[16]
	{
		"S", "P", "A", "P", "P", "A", "P", "S",
		"R", "N", "B", "C", "Q", "B", "N", "R"
	};

	private Dictionary<string, Type> pieceLibrary = new Dictionary<string, Type>()
	{
		{"P", typeof(Pawn)},
		{"R", typeof(Rook)},
		{"N", typeof(Knight)},
		{"B", typeof(Bishop)},
		{"C", typeof(Cursed)},
		{"Q", typeof(Queen)},
		{"A", typeof(Archer)},
		{"S", typeof(Scout)}
	};

	public void Setup(Board board)
    {
		whitePieces = CreatePieces(Color.white, new Color32(80, 124, 159, 255), board);
		blackPieces = CreatePieces(Color.black, new Color32(218, 95, 64, 255), board);

		Place(1, 0, whitePieces, board);
		Place(6, 7, blackPieces, board);

		SwitchSide(Color.black);
    }

	public void SwitchSide(Color color)
    {
		GameManager.TurnVal();
        if (!kingAlive)
        {
			Reset();
			kingAlive = true;
			color = Color.black;
        }

		bool blackTurn = color == Color.white ? true : false;
		if (blackTurn)
            GameManager.whiteTurn = false;
        else
        {
			GameManager.whiteTurn = true;
		}
        Interactive(whitePieces, !blackTurn);
		Interactive(blackPieces, blackTurn);
    }

	public void Reset()
    {
		foreach (Base piece in whitePieces)
			piece.Reset();

		foreach (Base piece in blackPieces)
			piece.Reset();
    }

	private void Interactive(List<Base> allPieces, bool value)
    {
		foreach (Base piece in allPieces)
			piece.enabled = value;
    }

	private List<Base> CreatePieces(Color teamColor, Color32 spriteColor, Board board)
    {
		List<Base> newPieces = new List<Base>();

		for(int i=0; i<pieceOrder.Length; i++)
        {
			GameObject gameObjectPiece = Instantiate(piecePrefab);
			gameObjectPiece.transform.SetParent(transform);
			gameObjectPiece.transform.localScale = new Vector3(1,1,1);
			gameObjectPiece.transform.localRotation = Quaternion.identity;
			Type pieceType = pieceLibrary[pieceOrder[i]];
			Base newP = (Base)gameObjectPiece.AddComponent(pieceType);
			newPieces.Add(newP);
			newP.Setup(teamColor, spriteColor, this);
        }

		return newPieces;
    }

	private void Place(int pawnRow, int royaltyRow, List<Base> pieces, Board board)
    {
		for(int i=0; i<8; i++)
        {
			pieces[i].Place(board.allCells[i, pawnRow]);
			pieces[i + 8].Place(board.allCells[i, royaltyRow]);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {

	public Image outline;

	[HideInInspector]
	public RectTransform rectTransform = null;
	public Board board = null;
	public Vector2Int boardPosition = Vector2Int.zero;
	public Base currentPiece = null;

	public void Setup(Vector2Int newBoardPosition, Board newBoard)
    {
		boardPosition = newBoardPosition;
		board = newBoard;
		rectTransform = GetComponent<RectTransform>();
    }

	public void Remove()
    {
		if (currentPiece != null)
			currentPiece.Kill();
    }
}

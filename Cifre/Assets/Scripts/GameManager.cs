using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Board board;
    public PieceManager pieceManager;
    public static int whiteScore = 0, blackScore = 0, turnValue = 0, whiteWinByPieces=0;
    public static bool whiteTurn = true;
    public int maxRuchy;
    public Text liczbaTur, player1, player2, winner;
    public GameObject canvas2, canvas3, canvas4, pieceMagangerGO, whiteTurnGO, blackTurnGO;

    public Color color;

	void Start()
    {
        board.Create();
        pieceManager.Setup(board);
    }

    public static void Score(int sc)
    {
        if (whiteTurn)
            whiteScore += sc;
        else
            blackScore += sc;
    }

    public static void TurnVal()
    {
        turnValue++;
    }

    void Update()
    {
        if (whiteTurn)
        {
            whiteTurnGO.SetActive(true);
            blackTurnGO.SetActive(false);
            player1.color = color;
            player2.color = Color.white;
        }
        else
        {
            whiteTurnGO.SetActive(false);
            blackTurnGO.SetActive(true);
            player2.color = color;
            player1.color = Color.white;
        }

        liczbaTur.text = "Tura: " + (turnValue / 2).ToString();
        player1.text = "Gracz 1\n " + whiteScore.ToString();
        player2.text = "Gracz 2\n " + blackScore.ToString();

        if(Input.GetKeyDown(KeyCode.Escape))
            canvas4.SetActive(true);

        if (turnValue >= maxRuchy)
        {
            if (whiteScore > blackScore)
            {
                winner.text = "Białe!";
                canvas2.SetActive(true);
            }
            else if (whiteScore < blackScore)
            {
                winner.text = "Czarne!";
                canvas2.SetActive(true);
            }
            else
                canvas3.SetActive(true);

            pieceMagangerGO.SetActive(false);
        }
        else if (whiteWinByPieces == 1)
        {
            winner.text = "Białe!";
            canvas2.SetActive(true);
        }
        else if (whiteWinByPieces == -1)
        {
            winner.text = "Czarne!";
            canvas2.SetActive(true);
        }

    }
}

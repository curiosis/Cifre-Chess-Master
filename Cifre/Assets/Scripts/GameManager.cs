using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Board board;
    public PieceManager pieceManager;
    private static int whiteScore = 0, blackScore = 0, turnValue = 0;
    public static bool whiteTurn = true;
    public int maxRuchy;
    public Text liczbaTur, player1, player2, winner;
    public GameObject canvas1, canvas2, pieceMagangerGO;

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
        liczbaTur.text = "Tura: " + (turnValue / 2).ToString();
        player1.text = "Gracz 1\n " + whiteScore.ToString();
        player2.text = "Gracz 2\n " + blackScore.ToString();

        if(turnValue >= maxRuchy)
        {
            if (whiteScore > blackScore)
            {
                winner.text = "Białe!";
                canvas1.SetActive(true);
            }
            else if (whiteScore < blackScore)
            {
                winner.text = "Czarne!";
                canvas1.SetActive(true);
            }
            else
            {
                canvas2.SetActive(true);
            }
            pieceMagangerGO.SetActive(false);
        
        }
    }
}

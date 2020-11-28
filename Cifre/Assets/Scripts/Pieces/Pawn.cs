using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pawn : Base
{
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 1;
        movement = new Vector3Int(0, 1, 0);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Pawn");
    }

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}
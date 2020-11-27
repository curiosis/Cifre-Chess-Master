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

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}

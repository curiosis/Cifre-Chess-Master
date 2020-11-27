using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Base
{
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 9;
        movement = new Vector3Int(7, 7, 7);
    }

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bishop : Base
{
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 3;
        movement = new Vector3Int(0, 0, 7);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Bishop");
    }
    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}
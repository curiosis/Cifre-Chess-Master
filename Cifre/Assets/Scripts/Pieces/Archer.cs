using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Archer : Base {
    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 2;
        movement = new Vector3Int(2, 2, 0);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Archer");

    }

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}
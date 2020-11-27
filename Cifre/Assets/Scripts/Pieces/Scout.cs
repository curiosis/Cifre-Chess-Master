using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scout : Base {

    public override void Setup(Color teamColor, Color32 spriteColor, PieceManager NewPieceManager)
    {
        base.Setup(teamColor, spriteColor, NewPieceManager);
        val = 2;
        movement = new Vector3Int(0, 0, 1);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Scout");
    }

    public override void Kill()
    {
        base.Kill();
        GameManager.Score(val);
    }
}

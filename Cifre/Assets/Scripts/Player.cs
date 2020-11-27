using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	int score = 0;

	public void ScoreShow()
    {
        Debug.Log(score);
    }
}

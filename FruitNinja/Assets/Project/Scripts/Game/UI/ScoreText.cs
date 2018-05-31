using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    private int score = 0;
    public int Score {
        get { return score; }
        set {
            score = value;
            GetComponent<Text>().text = "Score: " + score;
        }
    }
	// Use this for initialization
	void Start () {
        Score = 0;
	}
}

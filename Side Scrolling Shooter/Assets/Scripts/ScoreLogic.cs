using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour {
    Text text;

    int score;

	void Start () {
        score = 0;
        text = GetComponent<Text>();
        printScore();
        
	}
	
	void Update () {
        AddScore();	
	}

    public void AddScore() {
        score++;
        printScore();
    }

    void printScore() {
        text.text = "Score: " + score;
    }
}

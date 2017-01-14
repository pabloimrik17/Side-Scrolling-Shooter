using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour {

    public float enemyMovementSpeed = 0.6f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveEnemyLeft();
	}

    void moveEnemyLeft() {
        transform.Translate(-enemyMovementSpeed, 0, 0);
    }
}

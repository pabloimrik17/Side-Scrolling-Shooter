using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour {

    public float projectileMovementSpeed = 0.4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveProjectileRight();
    }

    void moveProjectileRight() {
        transform.Translate(projectileMovementSpeed, 0, 0);
    }
}

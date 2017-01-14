using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : MonoBehaviour {

    float maxPlayerY = 8.0f;
    float maxPlayerX = 20.0f;

    public float playerMovementSpeed = 0.5f;
    public float projectileXOffset = 1.0f;

    public GameObject projectile;
    
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        playerMovement();
        spawnProjectile();
    }

    void playerMovement() {
        if(Input.GetKey(KeyCode.W) && transform.position.y <= maxPlayerY) {
            transform.Translate(0, playerMovementSpeed, 0);
        } else if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerX) {
            transform.Translate(-playerMovementSpeed, 0, 0);
        } else if (Input.GetKey(KeyCode.S) && transform.position.y >= -maxPlayerY) {
            transform.Translate(0, -playerMovementSpeed, 0);
        } else if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerX) {
            transform.Translate(playerMovementSpeed, 0, 0);
        }
    }

    void spawnProjectile() {
        if(Input.GetKeyDown(KeyCode.K)) {
            Instantiate(projectile, new Vector3(transform.position.x + projectileXOffset, transform.position.y, 0), Quaternion.identity);
        }
    }
}

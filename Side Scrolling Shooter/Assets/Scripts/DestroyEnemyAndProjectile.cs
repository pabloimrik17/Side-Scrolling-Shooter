using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyAndProjectile : MonoBehaviour {

    public GameObject explosionParticle;

    ScoreLogic scoreLogic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Collision" || collision.gameObject.tag == "Projectile") {
            spawnExplosionParticle(collision.transform.position);
            Destroy(collision.gameObject);
            if (collision.gameObject.tag == "Collision") {
                callScoreLogic();
            }
        }
    } 

    void spawnExplosionParticle(Vector2 position) {
        Instantiate(explosionParticle, position, Quaternion.identity);
    }

    void callScoreLogic () {
        scoreLogic = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        scoreLogic.AddScore();
    }
}

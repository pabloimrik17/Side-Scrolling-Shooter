using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyAndProjectile : MonoBehaviour {

    public GameObject explosionParticle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Collision") {
            spawnExplosionParticle(collision.transform.position);
            Destroy(collision.gameObject);
        }
    } 

    void spawnExplosionParticle(Vector2 position) {
        Instantiate(explosionParticle, position, Quaternion.identity);
    }
}

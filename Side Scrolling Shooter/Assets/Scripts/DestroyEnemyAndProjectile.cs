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
            spawnExplosionParticle();
            Destroy(collision.gameObject);
        }
    } 

    void spawnExplosionParticle() {
        Instantiate(explosionParticle, new Vector3(transform.position.x, transform)
    }
}

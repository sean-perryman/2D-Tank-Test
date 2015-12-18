﻿using UnityEngine;
using System.Collections;

public class HouseBehavior : MonoBehaviour {
    public GameObject explosion;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bullet(Clone)")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(explosion, other.transform.position, other.transform.rotation);
        Destroy(other.gameObject);
    }
}

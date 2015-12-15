using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {
    public float bulletSpeed = 5.0f;

	void Start () {
	
	}
	
	void Update () {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);

        if (transform.position.x > 10 || transform.position.x < -10 || transform.position.y > 10 || transform.position.y < -10) { Destroy(this.gameObject); }
	}
}

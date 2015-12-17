using UnityEngine;
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

        if (coll.gameObject.name == "Tank")
        {
            Instantiate(explosion, coll.transform.position, coll.transform.rotation);
            Destroy(coll.gameObject);
        }
    }
}

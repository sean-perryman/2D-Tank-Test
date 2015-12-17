using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

    private IEnumerator KillOnAnimationEnd()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    void Update()
    {
        StartCoroutine(KillOnAnimationEnd());
    }
}

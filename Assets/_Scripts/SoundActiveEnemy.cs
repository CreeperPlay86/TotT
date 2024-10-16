using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundActiveEnemy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(destroyMe());
    }

    IEnumerator destroyMe()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}

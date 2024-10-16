using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    IEnumerator DestroyMe()
    {
        yield return new WaitForSeconds(0.55f);
        gameObject.SetActive(false);
    }

    public void go()
    {
        StartCoroutine(DestroyMe());
    }
}

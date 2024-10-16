using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamerKD : MonoBehaviour
{
    public GameObject audioScreamer;
    public GameObject audioScreamer1;
    void Start()
    {
        StartCoroutine(KDscreamer());
        StartCoroutine(ExitGame());
    }

    IEnumerator KDscreamer()
    {
        Instantiate(audioScreamer);
        Instantiate(audioScreamer1);
        yield return new WaitForSeconds(2);
        Instantiate(audioScreamer1);
        yield return new WaitForSeconds(2);
        Instantiate(audioScreamer1);
        yield return new WaitForSeconds(1);
        Instantiate(audioScreamer1);
    }

    IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
    }
}

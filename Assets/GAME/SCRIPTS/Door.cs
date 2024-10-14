using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   
    #region DATA
        public bool isOpen;
    #endregion

    public void openOrCloose()
    {
        if(!isOpen)
        {
            gameObject.GetComponent<Animator>().SetBool("goOpen", true);
            StartCoroutine(KDAnimation());
            isOpen = true;
        }
        else
        {
            isOpen = false;
            gameObject.GetComponent<Animator>().SetBool("goCloose", true);
            StartCoroutine(KDAnimation());
        }
    }


    IEnumerator KDAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Animator>().SetBool("goOpen", true);
        gameObject.GetComponent<Animator>().SetBool("goCloose", true);
    }
}

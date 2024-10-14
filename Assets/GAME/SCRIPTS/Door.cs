using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   
    #region DATA
        public bool isOpen;

        public bool goCloose;
        public bool goOpen;

        public bool kdAnimation;

        public float rotationY;
    #endregion

    public void openOrCloose()
    {
        if(!isOpen)
        {
            if(kdAnimation)
                return;
            StartCoroutine(KDAnimation());
            StartCoroutine(KDclose());
            isOpen = true;
            goOpen = true;
            kdAnimation = true;
        }
        else
        {
            if(kdAnimation)
                return;
            StartCoroutine(KDAnimation());
            StartCoroutine(KDclose());
            isOpen = false;
            goCloose = true;
            kdAnimation = true;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            openOrCloose();
        }
    }

    void FixedUpdate()
    {
        if(goCloose)
        {
            if(transform.rotation.y <= 180)
            {
                rotationY+=(Time.deltaTime * 85);
                transform.rotation = Quaternion.Euler(transform.rotation.x, 63 + rotationY, transform.rotation.z);
                if(transform.rotation.y > 180)
                {
                   kdAnimation = false; 
                   goCloose = false;
                }
            }
            else
            {
                kdAnimation = false; 
                goCloose = false;
            }
        }

        if(goOpen)
        {
            if(transform.rotation.y >= 63)
            {
                rotationY+=(Time.deltaTime * 85);
                transform.rotation = Quaternion.Euler(transform.rotation.x, 180 - rotationY, transform.rotation.z);
                if(transform.rotation.y < 63)
                {
                   kdAnimation = false; 
                   goOpen = false;
                }
            }
            else
            {
                kdAnimation = false; 
                goOpen = false;
            }
        }
    }


    IEnumerator KDAnimation()
    {
        yield return new WaitForSeconds(0.94f);
        gameObject.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        kdAnimation = false;
    }

    IEnumerator KDclose()
    {
        yield return new WaitForSeconds(1.375f);
        goCloose = false;
        goOpen = false;
        rotationY = 0;
    }
}

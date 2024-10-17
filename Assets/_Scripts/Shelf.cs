using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    #region DATA
        #region GAME OBJECTS
            public GameObject meAnimationOpen;
            public GameObject meOpenned;
            public GameObject meClosed;
            public GameObject meAnimationClose;
        #endregion

        #region BOOL
            public bool isOpen;
            public bool kdAnimation;
        #endregion

        #region STRING
            public string name;
        #endregion
    #endregion

    #region VOID
        public void openOrClose()
        {
            if(kdAnimation)
                return;
            kdAnimation = true;
            if(!isOpen)
            {
                meClosed.SetActive(false);
                meAnimationOpen.SetActive(true);
                meAnimationOpen.GetComponent<Animator>().Play("animationOpen");
                StartCoroutine(ActiveOpenned());
            }
            else
            {
                meOpenned.SetActive(false);
                meAnimationClose.SetActive(true);
                meAnimationClose.GetComponent<Animator>().Play("animationClose");
                StartCoroutine(ActiveClosed());
            }
            isOpen = !isOpen;
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                openOrClose();
            }
        }
        

        IEnumerator ActiveOpenned()
        {
            yield return new WaitForSeconds(0.5f);
            meOpenned.SetActive(true);
            kdAnimation = false;
        }

        IEnumerator ActiveClosed()
        {
            yield return new WaitForSeconds(0.5f);
            meClosed.SetActive(true);
            kdAnimation = false;
        }
    #endregion
}

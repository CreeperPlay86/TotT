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

            public GameObject distanceToPkayerObj;
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
                Debug.Log("тут ниче нет");
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

            // if(name == "open")
            // {
            //     if(distanceToPkayerObj.GetComponent<distanceToPkayer>().distance<= 0.8f)
            //     {
                    
            //     }
            // }
        }
        

        IEnumerator ActiveOpenned()
        {
            yield return new WaitForSeconds(0.5f);
            meOpenned.SetActive(true);
            meAnimationOpen.SetActive(false);
            kdAnimation = false;
        }

        IEnumerator ActiveClosed()
        {
            yield return new WaitForSeconds(0.5f);
            meClosed.SetActive(true);
            meAnimationClose.SetActive(false);
            kdAnimation = false;
        }
    #endregion
}

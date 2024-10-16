using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfZam : MonoBehaviour
{
    #region DATA
        #region CONNECT
            public GameObject myOwner;
        #endregion
    #endregion

    #region VOID
        public void doing()
        {
            myOwner.GetComponent<Shelf>().openOrClose();
            Debug.Log("тут тоже че то есть");
        }
    #endregion
}

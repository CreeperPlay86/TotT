using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeManager : MonoBehaviour
{
    #region DATA
        #region BOOL
            public bool inNumber0;
            public bool inNumber1;
            public bool inNumber2;
        #endregion

        #region CONNECT
            public GameObject player;
        #endregion
    #endregion

    void FixedUpdate()
    {
        if(!inNumber0 && !inNumber1 && !inNumber2)
        {
            player.GetComponent<PlayerControllerMain>().inTheWardrobe = false;
        }
        else
        {
            player.GetComponent<PlayerControllerMain>().inTheWardrobe = true;
        }
    }
}

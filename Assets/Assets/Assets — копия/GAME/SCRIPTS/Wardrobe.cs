using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    public void openOrCloose()
    {
        Debug.Log("да");
    }

    #region DATA
        #region FLOAT
            public float distanceToPlayer;
        #endregion  

        #region GAME OBJECTS and TRANSFORM
            public Transform player;
        #endregion

        #region INT
            public int number;

            public int level;
        #endregion

        #region CONNTECT
            public WardrobeManager WM;
        #endregion
    #endregion

    void Start()
    {
        level = PlayerPrefs.GetInt("level");
    }



    void FixedUpdate()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if(number == 0)
        {
            if(distanceToPlayer <= 1)
            {
                WM.inNumber0 = true;
                if(level <= 2)
                {
                    level = 3;
                    PlayerPrefs.SetInt("level", level);
                }
            }
            else
            {
                WM.inNumber0 = true;
            }
        }

        if(number == 1)
        {
            if(distanceToPlayer <= 1)
            {
                WM.inNumber1 = true;
                if(level <= 2)
                {
                    level = 3;
                    PlayerPrefs.SetInt("level", level);
                }
            }
            else
            {
                WM.inNumber1 = true;
            }
        }

        if(number == 2)
        {
            if(distanceToPlayer <= 1)
            {
                WM.inNumber2 = true;
                if(level <= 2)
                {
                    level = 3;
                    PlayerPrefs.SetInt("level", level);
                }
            }
            else
            {
                WM.inNumber2 = true;
            }
        }
    }
}

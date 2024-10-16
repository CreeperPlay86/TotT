using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    #region DATA
        #region INT
            public int progress;
        #endregion

        #region GAME OBJECTS
            public GameObject[] labels;
            public GameObject[] text;
        #endregion
    #endregion



    void Start()
    {
        if(progress == 0)
        {
            labels[0].SetActive(true);
            text[0].SetActive(true);
        }
    }



    public void updateLabels()
    {
        if(progress == 0)
        {
            labels[0].SetActive(true);
            text[0].SetActive(true);
        }

        if(progress == 1)
        {
            text[1].SetActive(true);
            text[0].SetActive(false);
        }

        if(progress == 2)
        {
            text[2].SetActive(true);
            text[1].SetActive(false);
            text[0].SetActive(false);
        }
    }
}

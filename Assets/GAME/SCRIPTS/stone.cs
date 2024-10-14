using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    #region DATA
        #region INT
            public int health;
        #endregion

        #region SOUND
            public GameObject soundDestroyStone;
        #endregion

        #region EFFECTS
            public GameObject effectsDestroyStone;
        #endregion
    #endregion


    void Start()
    {
        health = 100;
    }


    void Update()
    {
        if(health <= 0)
        {
            Instantiate(soundDestroyStone);
            effectsDestroyStone.SetActive(true);
            Destroy(gameObject);
        }
    }
}

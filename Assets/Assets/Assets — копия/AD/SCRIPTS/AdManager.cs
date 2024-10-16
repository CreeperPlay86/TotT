using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoBehaviour
{
    #region DATA
        #region GAME OBJECTS
            public GameObject door;
        #endregion

        #region CONNECT
            public PlayerController PC;
        #endregion

        #region  SOUND
            public GameObject soundOpenDoor;
        #endregion

        public float timer;
    #endregion

    void Update()
    {
        //if(PC.currentIdol >= 7)
        //{
        //    Destroy(door.gameObject);
        //    //soundOpenDoor.SetActive(true);
        //}
        timer += Time.deltaTime;    
        Debug.Log("СЕКУНДОМЕР: " + timer);
    }
}

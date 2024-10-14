using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerInTheMainHome : MonoBehaviour
{
    #region НАЧАЛО
        #region DATA
            public GameObject[] objEnvironment;

            public string nameLevel;
        #endregion



        private void OnTriggerEnter(Collider a)
        {
            if(a.gameObject.tag == "Environment1")
            {   
                objEnvironment[0].SetActive(false);
                SceneManager.LoadScene("KatSceneStart");
                nameLevel = "startOnTheHouse";
                PlayerPrefs.SetString("nameLevel", nameLevel);
            }
        }
    #endregion
}

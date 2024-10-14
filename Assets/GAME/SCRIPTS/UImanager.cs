using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    #region DATA
        #region INT
            public int level;
        #endregion

        #region CONNECT
            
        #endregion

        #region GAME OBJECTS and UI
            public GameObject player;

            public GameObject menuPanel;

            public GameObject tasksPanel;
        #endregion

        #region BOOL
            public bool isOpenMenu;
        #endregion
    #endregion



    void Start()
    {
        level = PlayerPrefs.GetInt("level");
    }



    void FixedUpdate()
    {
        #region ОБНОВЛЕНИЕ ЗАДАНИЙ
            level = player.GetComponent<PlayerControllerMain>().level;

    
        #endregion
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!isOpenMenu)
            {
                Cursor.lockState = CursorLockMode.None;
                menuPanel.SetActive(true);
                Time.timeScale = 0.05f;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                menuPanel.SetActive(false);
                tasksPanel.SetActive(false);
                Time.timeScale = 1f;
            }
            isOpenMenu = !isOpenMenu;
        }
    }



    #region VOID
        public void clickMainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void clickOpenTasks()
        {
            tasksPanel.SetActive(true);
        }
    #endregion
}

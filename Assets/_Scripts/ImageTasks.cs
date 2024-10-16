using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTasks : MonoBehaviour
{
    #region DATA
        #region bool
            public bool kdAnimation;

            public bool isOpen;
        #endregion

        #region ANIMATION
            public Animator Anim;
        #endregion
    #endregion


    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(kdAnimation)
                return;
            gameObject.GetComponent<Animator>().enabled = true;
            if(!isOpen)
            {
                Anim.Play("Open_TasksUIanim");
                Cursor.lockState = CursorLockMode.None; 
                StartCoroutine(KDanimIEOpen()); 
            }
            else
            {
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked; 
                Anim.Play("CloseTasksUI");
            }
            //kdAnimation = true;
            isOpen = !isOpen;
        }
    }

    IEnumerator KDanimIEOpen()
    {
        yield return new WaitForSeconds(1.05f);
        Time.timeScale = 0.05f;
    }

    IEnumerator KDanimIEClose()
    {
        yield return new WaitForSeconds(0.95f);
        gameObject.GetComponent<Animator>().SetBool("goClose", false);
        //gameObject.GetComponent<Animator>().enabled = false;
        kdAnimation = false;
    }
}

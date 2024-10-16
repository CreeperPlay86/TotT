using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour
{
    #region DATA
        #region FLOAT
            float aColorImg;

            public float distanceToPlayer;
        #endregion

        #region BOOL
            public bool isWin;
        #endregion

        #region UI
            public Text textWinOrLoose;
        #endregion

        #region CONNTECT
            public EnemyMovementAI EMAI;
            public PlayerController PC;
        #endregion

        #region GAME OBJECTS
            public GameObject player;
        #endregion
    #endregion

    //private void OnCollisionEnter(Collision a)
    //{
    //    if(a.gameObject.tag == "Player" && PC.currentIdol >= 7)
    //    {
    //        EMAI.isGoActiveBtn = true;
    //        gameObject.GetComponent<BoxCollider>().isTrigger = true;
    //        isWin = true;
    //    }
    //}

    void FixedUpdate()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer <= 1.7f && PC.currentIdol >= 7)
        {
            EMAI.isGoActiveBtn = true;
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            isWin = true;
        }
        if(!isWin)
            return;
        textWinOrLoose.text = "ПОБЕДА!";
        textWinOrLoose.GetComponent<Text>().color = new Color(0,1,0,aColorImg);
        aColorImg += (Time.deltaTime * 0.5f);
    }
}

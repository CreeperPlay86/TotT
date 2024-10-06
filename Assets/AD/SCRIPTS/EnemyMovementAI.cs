using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyMovementAI : MonoBehaviour
{
    #region DATA
        #region NAV MESH
            private UnityEngine.AI.NavMeshAgent agent;
        #endregion

        #region TRANSFORMS
            public Transform Player;
        #endregion
        
        #region FLOAT
            public float distanceToPlayer;

            float aColorImg;
        #endregion

        #region UI
            public GameObject btnLoad;

            public Text textWinOrLoose;
        #endregion

        #region BOOL
            public bool isGoActiveBtn;
        #endregion
    #endregion

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }



    void Update()
    {
        if(!isGoActiveBtn)
        {
            Vector3 direction = Player.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0);
            agent.SetDestination(Player.position); 
            agent.speed = 4.8f;
        }
    }

    void FixedUpdate()
    {
        distanceToPlayer = Vector3.Distance(transform.position, Player.position);
        if(distanceToPlayer <= 0.95f)
        {
            isGoActiveBtn = true;
            textWinOrLoose.text = "ПРОИГРЫШ!";
            textWinOrLoose.GetComponent<Text>().color = new Color(1,0,0,aColorImg);
        }

        if(isGoActiveBtn)
        {
            Player.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<NavMeshAgent>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            btnLoad.SetActive(true);
            btnLoad.GetComponent<Image>().color = new Color(1,1,1,0.98f);
            aColorImg += (Time.deltaTime * 0.5f);
            btnLoad.GetComponent<Image>().color = new Color(1,1,1,aColorImg);
            if(aColorImg >= 1)
            {
                gameObject.GetComponent<EnemyMovementAI>().enabled = false;
            }   

        }
    }
}

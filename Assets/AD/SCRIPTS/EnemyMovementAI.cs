using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        #endregion
    #endregion

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }



    void Update()
    {
        Vector3 direction = Player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0);
        agent.SetDestination(Player.position); 
        agent.speed = 5;
    }

    void FixedUpdate()
    {
        distanceToPlayer = Vector3.Distance(transform.position, Player.position);
        if(distanceToPlayer <= 0.95f)
        {
            btnLoad.SetActive(true);
            aColorImg += (Time.deltaTime * 0.5f);
            btnLoad.GetComponent<Image>().color = new Color(1,1,1,aColorImg);
        }
    }
}

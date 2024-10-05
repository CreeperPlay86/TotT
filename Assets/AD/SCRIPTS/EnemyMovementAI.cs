using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementAI : MonoBehaviour
{
    #region DATA
        #region NAV MESH
            private UnityEngine.AI.NavMeshAgent agent;
        #endregion

        #region TRANSFORMS
            public Transform Player;
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolObj : MonoBehaviour
{
    #region DATA
        #region  CONNECT
            public GameObject enemy;
        #endregion

        #region float
            public float distance;
        #endregion
    #endregion

    void Start()
    {
        StartCoroutine(myFixedUpdate());
    }


    void Update()
    {
        distance = Vector3.Distance(transform.position, enemy.transform.position);
    }

    IEnumerator myFixedUpdate()
    {
        yield return new WaitForSeconds(3f);
        if(distance <= 1.5f)
        {
            if(enemy.GetComponent<EnemyAIGame>().numberTarget >= 5)
                enemy.GetComponent<EnemyAIGame>().numberTarget = 0;
            else
                enemy.GetComponent<EnemyAIGame>().numberTarget++;
            enemy.GetComponent<EnemyAIGame>().isInspection = true;
        }
        StartCoroutine(myFixedUpdate());
    }
}

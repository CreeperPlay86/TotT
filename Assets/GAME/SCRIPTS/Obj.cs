using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    #region DATA
        #region GAME OBJECTS
            public GameObject audioDown;

            public GameObject enemy;
        #endregion

        #region FLOAT
            public float distance;
        #endregion
    #endregion



    void Update()
    {
        distance = Vector3.Distance(transform.position, enemy.transform.position);

        if(enemy.GetComponent<EnemyAIGame>().indexChase == 1)
        {
            enemy.GetComponent<EnemyAIGame>().objIsDown = false;
        }
        if(distance <= 2f)
        {
            if(enemy.GetComponent<EnemyAIGame>().numberTarget >= 5)
                enemy.GetComponent<EnemyAIGame>().numberTarget = 0;
            else
                enemy.GetComponent<EnemyAIGame>().numberTarget++;
            enemy.GetComponent<EnemyAIGame>().objIsDown = false;
            gameObject.GetComponent<Obj>().enabled = false;
        }
    }



    #region ПРЕДМЕТ ПАДАЕТ
        private void OnCollisionEnter(Collision  a)
        {
            if(a.gameObject.tag == "floor")
            {
                Instantiate(audioDown);
                if(!(enemy.GetComponent<EnemyAIGame>().target == enemy.GetComponent<EnemyAIGame>().Player))
                {
                    enemy.GetComponent<EnemyAIGame>().target = gameObject.transform;
                    enemy.GetComponent<EnemyAIGame>().objIsDown = true;
                }
            }
        }
    #endregion
}
